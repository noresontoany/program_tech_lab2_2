namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            txtres.Text = Properties.Settings.Default.str1.ToString();
        }

        private void resClick(object sender, EventArgs e)
        {
            List<int> nums = new List<int>();

            System.String str;

            try
            {

                str = this.txtres.Text;

                Properties.Settings.Default.str1 = str;
                Properties.Settings.Default.Save();

                var str2 = str.Split(" ");

                for (int i = 0; i < str2.Length; i++)
                {
                    nums.Add(int.Parse(str2[i]));
                }
        
            }
            catch (FormatException) 
            {
                return; 
            }

            

            var average = Logic.answer(nums);

            MessageBox.Show(average);

        }



        public class Logic
        {
            static public String answer(List<int> arr)
            {
                for (int i = 0; i < arr.Count - 1; i++)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        return $"номер {i} номер {i + 1}";
                    }
                }
                return "нет таких чисел";
            }
        }
        

    }
}