using System.Reflection;
using OpenAI_API;
using OpenAI_API.Completions;
using OpenAI_API.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Identity;

namespace myactivepett
{
    public partial class Form1 : Form
    {
        static Stress stress = new Stress();
        static Form67 form2 = new Form67();
        static MainP mainp = new MainP();
        static public User user = new User();
        public Form1()
        {
            InitializeComponent();
            form2.Activate();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
            this.Visible = false; // Hide the form when it's shown
            this.Hide();
            this.SendToBack();
        }

        static public void SwitchToStress()
        {
            stress.Activate();
            stress.Show();

        }

        static public void ButtonNextClicked()
        {
            NextQuestion();
        }

        static public void ButtonPreviousClicked()
        {
            PreviousQuestion();
        }

        private void DrinkWater(double waterDrank)
        {
            user.water += waterDrank;
        }

        static private readonly string[] avatars = { "alien.jpg", "rabbit.jpg", "dog.jpg", "cat.jpg" };

        static public void NextAvatar()
        {
            int currentAvatar = Array.IndexOf(avatars, user.avatar);
            user.avatar = avatars[currentAvatar == 3 ? 0 : ++currentAvatar];
        }
        static public void PreviousAvatar()
        {
            int currentAvatar = Array.IndexOf(avatars, user.avatar);
            user.avatar = avatars[currentAvatar == 0 ? 3 : --currentAvatar];
        }

        static public void SetAvatar(string imageName)
        {
            Image image = Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BMTracker\" + imageName);
            //set avatar_imageBox to image
        }

        static public void Register(string username, string password, bool gender, double weight, int height, int age, string goal)
        {
            if (!user.Register(username, password, gender, weight, height, age, goal)) MessageBox.Show("Username Already Taken!");
            else
            {
                mainp.Activate();
                mainp.Show();
            }
        }

        static public void Login(string username, string password)
        {
            if (!user.Login(username, password)) MessageBox.Show("Username or Password is Incorrect!");
            else
            {
                mainp.Activate();
                mainp.Show();
                mainp.Visible = false;
            }
        }

        private void MakeVisible()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.Opacity = 1;
        }

        static private int testScore = 0;
        static private List<int> scores = new List<int>();
        static private readonly string[] questions = { "Били разстроени поради нещо, което се е случило неочаквано?", "Чувствали, че не можете да контролирате важните неща в живота си?", "Се чувствали нервни и стресирани?", "Се чувствали уверени в способностите си да се справяте с личните си проблеми?", "Усещали, че нещата вървят както трябва?", "Чувствали, че не можете да се справите с всички неща, които трябва да направите?", "Успявали да контролирате емоциите си, причинени от раздразненията в живота ви?", "Чувствали, че сте над нещата?", "Били ядосани, поради случили се неща, извън вашият контрол?", "Усещали, че се наптруват твърде много предизвикателства и вече искате да се откажете?" };

        static int currentQuestion()
        {
            List<char> test = stress.lbl_questionNumber.Text.ToCharArray().ToList();
            test.RemoveAt(stress.lbl_questionNumber.Text.Length - 1);
            int num = Convert.ToInt32(new string (test.ToArray()));
            return num;
        }


        static void NextQuestion()
        {
            CalculateStress(Constants.NEXT_QUESTION, currentQuestion());
        }

        static void PreviousQuestion()
        {
            CalculateStress(Constants.PREVIOUS_QUESTION, currentQuestion());
        }

        static void CalculateStress(bool nextOrPreviousQuestion, int currentQuestion)
        {
            if (nextOrPreviousQuestion == Constants.NEXT_QUESTION)
            {
                if(currentQuestion == 10)
                {
                    stress.Hide();
                    mainp.Show();
                }

                testScore += GetPoints();
                scores.Add(GetPoints());

                ChangeToQuestionNumber(++currentQuestion);

                if (currentQuestion == 10)
                {
                    ChangeNextButton(Constants.FINISH_BUTTON_TEXT);
                }
                else ChangeNextButton(Constants.NEXT_BUTTON_TEXT);

                if (currentQuestion == questions.Length + 1)
                {
                    FinishStressTest(testScore);
                    return;
                }

                ChangeQuestionLabel(questions[currentQuestion - 1]);
            }
            else
            {
                if (currentQuestion == 1)
                {
                    testScore = 0;
                    scores.Clear();
                    stress.Hide();
                    mainp.Show();
                    return;
                }

                testScore -= scores[scores.Count - 1];
                scores.RemoveAt(scores.Count - 1);

                ChangeToQuestionNumber(--currentQuestion);
                ChangeQuestionLabel(questions[currentQuestion - 1]);
            }
        }

        static void ChangeNextButton(string text)
        {
            stress.btn_Next1.Text = text;
        }

        static void FinishStressTest(int score)
        {
            testScore = 0;
            scores.Clear();
            user.stressScore = score;
            //go to panel after stress test/home page;
        }

        static int GetPoints()
        {
            if (stress.radioButton1.Checked) return 1;
            else if (stress.radioButton2.Checked) return 2;
            else if (stress.radioButton3.Checked) return 3;
            else if (stress.radioButton4.Checked) return 4;
            else if (stress.radioButton5.Checked) return 5;
            return 0;
        }

        static void ChangeQuestionLabel(string question)
        {
            stress.lbl_question.Text = question;
            stress.radioButton1.Checked = false;
            stress.radioButton2.Checked = false;
            stress.radioButton3.Checked = false;
            stress.radioButton4.Checked = false;
            stress.radioButton5.Checked = false;
        }
        static void ChangeToQuestionNumber(int changeToQuestionNumber)
        {
            stress.lbl_questionNumber.Text = changeToQuestionNumber.ToString() + ".";
        }
    }

    static class Constants
    {
        public const bool GENDER_MALE = false;
        public const bool GENDER_FEMALE = true;
        public const bool NEXT_QUESTION = false;
        public const bool PREVIOUS_QUESTION = true;
        public const string EMPTY_STRING = "null";
        public const string NEXT_BUTTON_TEXT = "Следващ";
        public const string FINISH_BUTTON_TEXT = "Край";
    }

    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool gender { get; set; }
        public double weight { get; set; }
        public int height { get; set; }
        public int age { get; set; }
        public string goal { get; set; }
        public int caloriesToday { get; set; }
        public double BMI { get; set; }
        public double BMR { get; set; }
        public double water { get; set; }
        private string workRegiment = Constants.EMPTY_STRING;
        public string workoutRegiment
        {
            get
            {
                if (this.workRegiment == Constants.EMPTY_STRING)
                {
                    this.workoutRegiment = GetWorkoutRegiment();
                    this.workRegiment = this.workoutRegiment;
                    return this.workoutRegiment;
                }
                return this.workoutRegiment;
            }
            set
            {
                this.workoutRegiment = value;
            }
        }
        private int StressScore = 0;
        public int stressScore
        {
            get
            {
                return StressScore;
            }
            set
            {
                //SaveStressScore(value);
                StressScore = value;
            }
        }
        public int oldStressScore { get; set; }
        public string avatar
        {
            get
            {
                return avatar;
            }
            set
            {
                this.avatar = value;
                //SetAvatar(value);
            }
        }

        private void SaveStressScore(int stressScore)
        {
            List<string> fileContent = new List<string>();
            if(File.Exists(filePath)) fileContent.AddRange(File.ReadAllLines(filePath));

            string userInfo = username + ":" + password + ":" + gender.ToString() + ":" + weight.ToString() + ":" + height.ToString() + ":" + age.ToString() + ":" + goal.ToString();

            if (this.stressScore != 0)
            {
                this.oldStressScore = this.stressScore;
                this.stressScore = stressScore;
                userInfo += ":" + this.stressScore.ToString() + ":" + oldStressScore.ToString() + ":" + water.ToString();
            }
            else
            {
                this.stressScore = stressScore;
                userInfo += ":" + this.stressScore.ToString() + ":" + "0" + ":" + water.ToString();
            }

            for (int i = 0; i < fileContent.Count; i++)
            {
                if (fileContent[i].Contains(username + ":" + password))
                {
                    fileContent[i] = userInfo;
                }
            }

            File.WriteAllLines(filePath, fileContent.ToArray());
        }

        private void SetAvatar(string imageName) => Form1.SetAvatar(imageName);

        static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\BMTracker\userAccounts.txt";

        private string GetWorkoutRegiment()
        {
            var api = new OpenAIAPI("...");
            var chat = api.Chat.CreateConversation();
            chat.Model = new Model("gpt-3.5-turbo-16k-0613") { OwnedBy = "openai" };
            string request = "Направи ми седмичен тренировъчен план за " + (gender ? "жена" : "мъж") + ", на " + age.ToString() + " години с цел " + goal + " и с Индекс Телесна Маса от " + BMI.ToString() + @" в този формат: 1. Колко дни от седмицата ще се тренира (спрямо възрастта, Индекс Телесна Маса и пола)\n 2. ТОЧНО кои ще са упражненията които да бъдат извършени (без каквито и да е упражнения с тежести, само с телесно тегло/гравитация), колко повторения и серии и колко да се почива между тях.\n Не казвай неща като 'не разполагам с персоналните ви данни и предпочитания относно тренировките', защото това не ни е необходимо, просто искаме тренировъчен план (както и не казвай НИЩО преди и след планът, без НИКАКВИ бележки и т.н., освен ако не е 'загрявайте 10 минути...). \n squats = клекове, jumping jacks = подскоци звезда, pushups = лицеви, crunches = коремни";
            chat.AppendUserInput(request);

            string result = chat.GetResponseFromChatbotAsync().Result;

            return result;
        }

        public void AddCalories(string food, int grams)
        {
            this.caloriesToday += FoodCalories(food, grams);
        }

        public int FoodCalories(string food, int grams)
        {
            int caloriesPer100Grams = 0;
            if (food == "Банан") caloriesPer100Grams = 89;
            else if (food == "Пилешко филе") caloriesPer100Grams = 165;
            else if (food == "Кока Кола") caloriesPer100Grams = 38;
            else if (food == "Шоколад") caloriesPer100Grams = 546;
            else if (food == "Сирене") caloriesPer100Grams = 246;
            return Convert.ToInt32(caloriesPer100Grams * (grams / 100.0));
        }

        public bool Login(string username, string password)
        {
            if (IsRegistered(username, password))
            {
                this.username = username;
                this.password = password;
                List<string> stats = new List<string>();
                foreach (string line in File.ReadAllLines(filePath))
                {
                    if (line.Contains(username + ":" + password))
                    {
                        this.gender = Convert.ToBoolean(line.Split(':').Skip(2).Single());
                        this.weight = Convert.ToDouble(line.Split(':').Skip(3).Single());
                        this.height = Convert.ToInt32(line.Split(':').Skip(4).Single());
                        this.age = Convert.ToInt32(line.Split(':').Skip(5).Single());
                        this.goal = line.Split(':').Skip(6).Single();
                        this.stressScore = Convert.ToInt32(line.Split(':').Skip(7).Single());
                        this.oldStressScore = Convert.ToInt32(line.Split(':').Skip(8).Single());
                        this.workoutRegiment = line.Split(':').Skip(9).Single();
                        this.water = Convert.ToDouble(line.Split(':').Skip(10).Single());
                        this.BMI = this.weight / (this.height / 100.0 * this.height / 100.0);
                        this.BMR = CalculateBMR(gender, weight, height, age);
                        return true;
                    }
                }
            }
            return false;
        }

        double CalculateBMR(bool gender, double weight, int height, int age)
        {
            if (gender == Constants.GENDER_MALE)
            {
                return 88.362 + (13.397 * this.weight) + (4.799 * this.height) - (5.677 * this.age);
            }
            else
            {
                return 447.593 + (9.247 * this.weight) + (3.098 * this.height) - (4.330 * this.age);
            }
        }

        bool IsRegistered(string username, string password)
        {
            return File.ReadAllLines(filePath).Any(s => s.Contains(username + ":" + password));
        }

        public bool Register(string username, string password, bool gender, double weight, int height, int age, string goal)
        {
            List<string> fileContent = new List<string>();
            if (File.Exists(filePath)) fileContent.AddRange(File.ReadAllLines(filePath));
            if (fileContent.Any(s => s.Contains(username + ":" + password))) return false;
            string userInfo = username + ":" + password + ":" + gender.ToString() + ":" + weight.ToString() + ":" + height.ToString() + ":" + age.ToString() + ":" + goal.ToString() + ":" + "0" + ":" + "0" + ":" + Constants.EMPTY_STRING + ":" + "0";
            fileContent.Add(userInfo);
            File.WriteAllLines(filePath, fileContent.ToArray());
            this.username = username;
            this.password = password;
            this.gender = gender;
            this.weight = weight;
            this.height = height;
            this.goal = goal;
            this.age = age;
            this.water = 0;
            this.stressScore = 0;
            this.oldStressScore = 0;
            this.BMI = this.weight / (this.height / 100.0 * this.height / 100.0);
            this.BMR = CalculateBMR(gender, weight, height, age);
            return true;
        }

    }
}