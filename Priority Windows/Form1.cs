using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Priority_Windows
{
    public partial class Form1 : Form
    {
        List<process> list = new List<process>();
       
        public Form1()
        {
            InitializeComponent();
           
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            list.Add(new process(Namee.Text, Convert.ToInt32(ArrivalBox.Text), Convert.ToInt32(BurstBox.Text)
                , Convert.ToInt32(PrioBox.Text)));
            Namee.Text = "";
            ArrivalBox.Text = "";
            BurstBox.Text = "";
            PrioBox.Text = "";
        }
        List<process> SortListArr(List<process>list)
        {
            for (int i = 0; i < list.Count; i++)
                list.Sort((x, y) => x.arrival.CompareTo(y.arrival));
            return list;
        }
        List<process> SortListPrio(List<process> list)
        {
            for (int i = 0; i < list.Count; i++)
                list.Sort((x, y) => x.priority.CompareTo(y.priority));
            return list;
        }
        private void resBtn_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
                MessageBox.Show("You have to enter a process");
            else
            {

                list = SortListArr(list);

                int Time = list[0].arrival;
                list[0].start = Time;
                int j = 0;

                int MaxArrivalTime = list[list.Count - 1].arrival;
                List<process> ResultList = new List<process>();
                ResultList.Add(list[j]);


                do
                {
                    var myItem = list.Find(item => item.arrival == Time);
                    if (myItem != null)
                    {
                        if (myItem.priority < ResultList[j].priority)
                        {

                            ResultList[j].burst -= Time;
                            ResultList[j].finish = Time;
                            if (ResultList[j].burst == 0)
                                list.Remove(ResultList[j]);
                            myItem.start = Time;
                            ResultList.Add(myItem);
                            j = ResultList.FindIndex(a => a.start == Time);
                        }
                    }
                    Time++;

                } while (Time <= MaxArrivalTime);
                ResultList[j].finish = ResultList[j].start + ResultList[j].burst;
                ResultFlow.Text = "";

                ResultFlow.Text += ResultList[0].start + " " + ResultList[0].name + " " + ResultList[0].finish + " ";
                for (int y = 1; y < ResultList.Count; y++)
                {
                    ResultFlow.Text += ResultList[y].name + " " + ResultList[y].finish + " ";
                }

                list = SortListPrio(list);
                
                List<process> ResultList2 = new List<process>();
                for (int k = 1; k < list.Count; k++)
                {
                    list[k].start = list[k - 1].finish;
                    list[k].finish = list[k - 1].finish + list[k].burst;

                    ResultList2.Add(list[k]);

                }

                for (int y = 0; y < ResultList2.Count; y++)
                {
                    if (y == ResultList2.Count - 1)
                        ResultFlow.Text += ResultList2[y].name + " " + ResultList2[y].finish;
                    else
                        ResultFlow.Text += ResultList2[y].name + " " + ResultList2[y].finish+" ";
                }
              
            }
            
        }
        
        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
