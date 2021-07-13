using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionSystem
{
    public partial class Form1 : Form
    {
        private Util.CSVReader questionReader;
        private Util.CSVReader datasetGrammarExercises;
        // TODO add new dataset

        public enum DatasetSetting
        {
            None, GrammarExercises
        }

        public enum ModeSetting
        {
            None, HideAnswer, CheckAnswer, ShowAnswer
        }

        public enum OrderSetting
        {
            None, Shuffle, InOrder
        }

        public enum Phase
        {
            Initialize, Ready, Question, Result
        }

        public enum AnswerResponse
        {
            None, A, B, C, D
        }

        public DatasetSetting datasetSetting = DatasetSetting.None;
        public ModeSetting modeSetting = ModeSetting.None;
        public OrderSetting orderSetting = OrderSetting.None;
        public int numberSetting = 0;
        public Phase phase = Phase.Ready;

        public string datasetPath;
        public int maxNumberOfQuestions = -1;
        public List<int> questionIndexList;

        public int currentQuestionNum = -1;
        public List<string> currentQuestion;
        public AnswerResponse currentAnswerResponse = AnswerResponse.None;
        public List<KeyValuePair<int, AnswerResponse>> responseList;

        public int rightAnswerNum = 0;


        public Form1()
        {
            InitializeComponent();
            datasetGrammarExercises = new Util.CSVReader(@"..\..\Datasets\GrammarExercises\Question.csv", true);
            // TODO add new dataset
            phase = Phase.Initialize;
            Initialize();
        }

        public void Initialize()
        {
            if (phase != Phase.Initialize) return;

            buttonStart.Enabled = false;
            radioButtonDatasetGrammar.Checked = false;
            radioButtonModeHide.Checked = false;
            radioButtonModeCheck.Checked = false;
            radioButtonModeShow.Checked = false;
            radioButtonOrderShuffle.Checked = false;
            radioButtonOrderInOrder.Checked = false;
            radioButtonNumberAll.Checked = false;
            radioButtonNumberCustom.Checked = false;
            numericUpDownNumber.Value = 1;
            radioButtonModeHide.Enabled = false;
            radioButtonModeCheck.Enabled = false;
            radioButtonModeShow.Enabled = false;
            radioButtonOrderShuffle.Enabled = false;
            radioButtonOrderInOrder.Enabled = false;
            radioButtonNumberAll.Enabled = false;
            radioButtonNumberCustom.Enabled = false;
            numericUpDownNumber.Enabled = false;

            datasetSetting = DatasetSetting.None;
            modeSetting = ModeSetting.None;
            orderSetting = OrderSetting.None;
            numberSetting = 0;
            maxNumberOfQuestions = -1;
            currentQuestionNum = -1;
            currentAnswerResponse = AnswerResponse.None;
            questionReader = null;

            panelReady.Visible = true;
            phase = Phase.Ready;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (datasetSetting == DatasetSetting.None || modeSetting == ModeSetting.None) return;
            maxNumberOfQuestions = questionReader.GetColumn(0).Count;
            switch (orderSetting)
            {
                case OrderSetting.Shuffle:
                    if (numberSetting == 0) return;
                    else if (numberSetting == -1) numberSetting = maxNumberOfQuestions;
                    List<int> indexList = Enumerable.Range(0, maxNumberOfQuestions).ToList();
                    questionIndexList = new List<int>(numberSetting);
                    for (int i = 0; i < numberSetting; i++)
                    {
                        Random r = new Random();
                        int ii = r.Next(indexList.Count);
                        questionIndexList.Add(indexList[ii]);
                        indexList.RemoveAt(ii);
                    }
                    break;
                case OrderSetting.InOrder:
                    numberSetting = maxNumberOfQuestions;
                    questionIndexList = Enumerable.Range(0, maxNumberOfQuestions).ToList();
                    break;
                default:
                    return;
            }
            currentQuestionNum = -1;
            rightAnswerNum = 0;
            phase = Phase.Question;
            progressBar1.Maximum = numberSetting;
            responseList = new List<KeyValuePair<int, AnswerResponse>>();
            NextQuestion();
            panelQuestion.Visible = true;
            panelReady.Visible = false;
        }

        private void CheckButtonStartEnable()
        {
            if (datasetSetting != DatasetSetting.None && modeSetting != ModeSetting.None &&
                orderSetting != OrderSetting.None && numberSetting != 0)
            {
                buttonStart.Enabled = true;
            }
            else
            {
                buttonStart.Enabled = false;
            }
        }

        private void radioButtonDatasetGrammar_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonDatasetGrammar.Checked)
            {
                datasetSetting = DatasetSetting.GrammarExercises;
                datasetPath = @"..\..\Datasets\GrammarExercises\";
                questionReader = datasetGrammarExercises;
                radioButtonModeHide.Enabled = true;
                radioButtonModeCheck.Enabled = true;
                radioButtonModeShow.Enabled = true;
                numericUpDownNumber.Maximum = questionReader.GetColumn(0).Count;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonModeHide_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonModeHide.Checked)
            {
                modeSetting = ModeSetting.HideAnswer;
                radioButtonOrderShuffle.Enabled = true;
                radioButtonOrderInOrder.Enabled = true;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonModeCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonModeCheck.Checked)
            {
                modeSetting = ModeSetting.CheckAnswer;
                radioButtonOrderShuffle.Enabled = true;
                radioButtonOrderInOrder.Enabled = true;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonModeShow_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonModeShow.Checked)
            {
                modeSetting = ModeSetting.ShowAnswer;
                radioButtonOrderShuffle.Enabled = true;
                radioButtonOrderInOrder.Enabled = true;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonOrderShuffle_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonOrderShuffle.Checked)
            {
                orderSetting = OrderSetting.Shuffle;
                radioButtonNumberAll.Enabled = true;
                radioButtonNumberCustom.Enabled = true;
                numericUpDownNumber.Enabled = false;
                radioButtonNumberAll.Checked = false;
                radioButtonNumberCustom.Checked = false;
                numberSetting = 0;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonOrderInOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonOrderInOrder.Checked)
            {
                orderSetting = OrderSetting.InOrder;
                radioButtonNumberAll.Checked = true;
                radioButtonNumberCustom.Checked = false;
                radioButtonNumberAll.Enabled = false;
                radioButtonNumberCustom.Enabled = false;
                numericUpDownNumber.Enabled = false;
                numberSetting = -1;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonNumberAll_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonNumberAll.Checked)
            {
                numberSetting = -1;
                numericUpDownNumber.Enabled = false;
            }
            CheckButtonStartEnable();
        }

        private void radioButtonNumberCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonNumberCustom.Checked)
            {
                numericUpDownNumber.Enabled = true;
                numericUpDownNumber.Maximum = questionReader.GetColumn(0).Count;
                numberSetting = Math.Min((int)numericUpDownNumber.Value, (int)numericUpDownNumber.Maximum);
            }
            CheckButtonStartEnable();
        }

        private void numericUpDownNumber_ValueChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Ready && radioButtonNumberCustom.Checked)
            {
                numberSetting = Math.Min((int)numericUpDownNumber.Value, (int)numericUpDownNumber.Maximum);
            }
        }

        private void NextQuestion()
        {
            if (phase != Phase.Question) return;
            currentQuestionNum++;
            progressBar1.Value = currentQuestionNum;
            if (currentQuestionNum == questionIndexList.Count)
            {
                ShowResult();
                return;
            }
            currentQuestion = questionReader.GetRow(questionIndexList[currentQuestionNum]);
            pictureBox1.Image = Image.FromFile(datasetPath + currentQuestion[questionReader.GetHeaderIndex("filename")]);
            currentAnswerResponse = AnswerResponse.None;
            radioButtonA.Checked = false;
            radioButtonB.Checked = false;
            radioButtonC.Checked = false;
            radioButtonD.Checked = false;
            buttonNext.Enabled = false;
        }

        private void radioButtonA_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Question && radioButtonA.Checked)
            {
                currentAnswerResponse = AnswerResponse.A;
                buttonNext.Enabled = true;
            }
        }

        private void radioButtonB_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Question && radioButtonB.Checked)
            {
                currentAnswerResponse = AnswerResponse.B;
                buttonNext.Enabled = true;
            }
        }

        private void radioButtonC_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Question && radioButtonC.Checked)
            {
                currentAnswerResponse = AnswerResponse.C;
                buttonNext.Enabled = true;
            }
        }

        private void radioButtonD_CheckedChanged(object sender, EventArgs e)
        {
            if (phase == Phase.Question && radioButtonD.Checked)
            {
                currentAnswerResponse = AnswerResponse.D;
                buttonNext.Enabled = true;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (phase != Phase.Question || currentAnswerResponse == AnswerResponse.None) return;
            buttonNext.Enabled = false;
            KeyValuePair<int, AnswerResponse> response = new KeyValuePair<int, AnswerResponse>(
                questionIndexList[currentQuestionNum], currentAnswerResponse);
            string answer = currentQuestion[questionReader.GetHeaderIndex("answer")];
            if (currentAnswerResponse.ToString().ToLower() == answer.ToLower())
            {
                rightAnswerNum++;
            }
            if (modeSetting == ModeSetting.ShowAnswer)
            {
                if (currentAnswerResponse.ToString().ToLower() == answer.ToLower())
                {
                    MessageBox.Show("You're right! The answer is (" + answer.ToLower() + ").",
                        "You're right!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong answer! Your answer is (" + currentAnswerResponse.ToString().ToLower() +
                        "), but the right answer is (" + answer.ToLower() + ").",
                        "Wrong answer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (modeSetting == ModeSetting.CheckAnswer)
            {
                if (currentAnswerResponse.ToString().ToLower() == answer.ToLower())
                {
                    MessageBox.Show("You're right! The answer is (" + answer.ToLower() + ").",
                        "You're right!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Wrong answer! Your answer is (" + currentAnswerResponse.ToString().ToLower() +
                        "), but it's wrong.", "Wrong answer!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            NextQuestion();
        }

        private void ShowResult()
        {
            if (phase != Phase.Question) return;
            //phase = Phase.Result;
            phase = Phase.Initialize;
            //panelResult.Visible = true;
            // TODO
            float accuracy = rightAnswerNum / (float)numberSetting;
            MessageBox.Show("Finish! Your score is " + accuracy + "% (" + rightAnswerNum + "/" + numberSetting + ").",
                "Finish!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelQuestion.Visible = false;
            Initialize();
        }
    }
}
