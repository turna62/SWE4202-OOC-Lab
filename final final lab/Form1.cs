namespace final_final_lab
{
    public partial class Form1 : Form
    {
        List<rps> rpss = new List<rps>();
        public Form1()
        {
            InitializeComponent();

            using (var reader = new StreamReader(@"C:\Users\Lenovo\Downloads\MarkSheet.csv"))
            {
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();
                reader.ReadLine();

                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    
                    rps rpS = new rps();
                    rpS.id = values[0];
                    rpS.name = values[1];
                    rpS.attendance = values[2];
                    rpS.quiz1 = values[3];
                    rpS.quiz2 = values[4];
                    rpS.quiz3=values[5];
                    rpS.quiz4=values[6];
                    rpS.mid=values[7];
                    rpS.final=values[8];
                    rpS.viva= values[9];

                    rps.Add(rpS);

                    listbox.Items.Clear();

                    foreach (rps rpS in rpss)
                    {
                        listbox.Items.Add(rpS.getInfo());
                    }




                }





            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = idsearchtxt.Text;

            foreach(rps rpS in rpss)
            {
                if(id==rpS.id)
                {
                    int quiztotal = Convert.ToInt32(rpS.quiz1 + Convert.ToInt32(rpS.quiz2) + Convert.ToInt32(rpS.quiz3);
                    double total = Convert.ToInt32(rpS.attendance) + Convert.ToInt32(rpS.mid) + Convert.ToInt32(rpS.final) + Convert.ToInt32(rpS.viva) + quiztotal;
                    double percentage = (total / 3);
                    string grade = "";

                    if (percentage < 40)
                        grade = "F";
                    else if (percentage < 45 && percentage >= 40)
                        grade = "D";
                    else if (percentage < 50 && percentage >= 45)
                        grade = "C";
                    else if (percentage < 55 && percentage >= 50)
                        grade = "C+";
                    else if (percentage < 60 && percentage >= 55)
                        grade = "B-";
                    else if (percentage < 65 && percentage >= 60)
                        grade = "B";
                    else if (percentage < 70 && percentage >= 65)
                        grade = "B+";
                    else if (percentage < 75 && percentage >= 70)
                        grade = "A-";
                    else if (percentage < 80 && percentage >= 75)
                        grade = "A";
                    else
                        grade = "A+";

                    attendancelabel.Text = rpS.attendance;
                    quiz1label.Text = rpS.quiz1;
                    quiz2label.Text = rpS.quiz2;
                    quiz3label.Text = rpS.quiz3;
                    quiz4label.Text = rpS.quiz4;
                    quiztotallabel.Text = rpS.quiztotal;
                    midlabel.Text = rpS.mid;
                    finallabel.Text = rpS.final;
                    vivalabel.Text = rpS.viva;
                    totallabel.Text = rpS.total;
                    




                }
            }
        }
    }
}