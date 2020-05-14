/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 04/05/2020
 * Time: 08.39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using CPU.algo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace CPU{
	public partial class Form1 : Form
    {
        private List<Process> bfp = new List<Process>();

        FIFO fifo;

        RR rr;

        SJF sjf;
        

        private int clockTime = 0;
        public Form1()
        {
            InitializeComponent();
            qATextBox.Text += "ID        Priority        CPU    Burst Time";
            qBTextBox.Text += "ID        Priority        CPU    Burst Time";
            qCTextBox.Text += "ID        Priority        CPU    Burst Time";
        }

       	private void BrowseClick(object sender, EventArgs e){
			OpenFileDialog openFileDialog1 = new OpenFileDialog{
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK){
                textBox1.Text = openFileDialog1.FileName;
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog1.FileName);
                tampilanfile.Text = sr.ReadToEnd();
                sr.Close();
            }
		}

        private void button3_Click(object sender, EventArgs e)
        {
            
            using (var fileStream = File.OpenRead(textBox1.Text.ToString()))
            using (StreamReader sr = new StreamReader(fileStream))
            {
                String line;

                while ((line = sr.ReadLine()) != null)
                {


                    List<String> items = new List<string>(line.Split(' '));
                    Process process = new Process(
                        Int32.Parse(items[0]),
                        Int32.Parse(items[1]),
                        Int32.Parse(items[2]),
                        Int32.Parse(items[3]),
                        Int32.Parse(items[4]),
                        Int32.Parse(items[5])
                     );
                    bfp.Add(process);
                }

                fifo = new FIFO(bfp);
                rr = new RR(bfp);
                sjf = new SJF(bfp);
            }
        }


        private void btnclock_Click(object sender, EventArgs e)
        {
            qA.Text = String.Empty;
            qB.Text = String.Empty;
            qC.Text = String.Empty;

            textBox2.Text = clockTime.ToString();
            foreach (var p in fifo.processes)
            {
                if (p.getBurstTime() > 0)
                {
                    qA.Text += p.getId().ToString() + "\t   " + p.getPrioritas().ToString() + "\t\t" + p.getBurstTime() + Environment.NewLine;
                    qA.Text += "--------------------------------------------------";
                    qA.AppendText(Environment.NewLine);
                }              
                else
                {
                    qA.Text += p.getId().ToString() + "\t   " + " " + "\t\t" + "Selesai" + Environment.NewLine;
                    qA.Text += "--------------------------------------------------";
                    qA.AppendText(Environment.NewLine);
                }
                
            }

            foreach (var p in rr.processes)
            {
            	
            		
                if (p.getBurstTime() > 0)
                {
                    qB.Text += p.getId().ToString() + "\t   " + p.getPrioritas().ToString() + "\t\t" + p.getBurstTime()+ Environment.NewLine;
                    qB.Text += "--------------------------------------------------";
                    qB.AppendText(Environment.NewLine);
					
                    
                }
                else if(p.getId()==0)
                {
                	qB.Text += "\t    " + "1 putaran  " + " " + "   " + "Selesai" + Environment.NewLine;
                    qB.Text += "--------------------------------------------------";
                    qB.AppendText(Environment.NewLine);	
                }
                else
                {
                    qB.Text += p.getId().ToString() + "\t   " + " " + "\t\t" + "Selesai" + Environment.NewLine;
                    qB.Text += "--------------------------------------------------";
                    qB.AppendText(Environment.NewLine);
                }
                
                
                
                
            }

            foreach (var p in sjf.processes)
            {
                if (p.getBurstTime() > 0)
                {
                    qC.Text += p.getId().ToString() + "\t   " + p.getPrioritas().ToString() + "\t\t" + p.getBurstTime()  + Environment.NewLine;
                    qC.Text += "--------------------------------------------------";
                    qC.AppendText(Environment.NewLine);
                }
                else
                {
                    qC.Text += p.getId().ToString() + "\t   " + " " + "\t\t" + "Selesai" + Environment.NewLine;
                    qC.Text += "--------------------------------------------------";
                    qC.AppendText(Environment.NewLine);
                }
            }
            
            
        	Process ffDemo = fifo.tick();
        	Process rrDemo = rr.tick();
            List<Process> sjfDemo = sjf.tick();
            if (sjfDemo.Count > 0)
            {
                foreach (var p in sjfDemo)
                {
                    p.setWaitingClock(0);
                }
                while (fifo.processes.Count < 10 && sjfDemo.Count > 0)
                {
                    tblog.Text += "Promosi dari Qc ke Qa dengan ID : " + sjfDemo[0].getId() + " pada clock ke = " + clockTime;
                    sjfDemo[0].setFirst(!sjfDemo[0].getFirst());
                    fifo.processes.Add(sjfDemo[0]);
                    sjfDemo.RemoveAt(0);
                }
                tblog.AppendText(Environment.NewLine);
            }
           
            
            if (rrDemo.getId() != 0){
            	
                tblog.Text += "Demosi dari Qb ke Qc dengan ID : " + rrDemo.getId() + " pada clock ke = " + clockTime;
                rrDemo.setWaitingClock(0);
                rrDemo.setBurstTime(rrDemo.getBurstTime() + 1);
                sjf.processes.Add(rrDemo);
                tblog.AppendText(Environment.NewLine);
            }
            
            
            if((RR.totalRound-3)%3==1 && RR.totalRound<13)
                    {
            	
            			rrDemo.setId(0);
             			rr.processes.Add(rrDemo);
                    	qB.AppendText(Environment.NewLine);
                    	
            }
          
            

            if (sjfDemo.Count > 0){
                foreach (var p in sjfDemo)
                {
                    tblog.Text += "Demosi dari Qa ke Qb dengan ID : " + p.getId() + " pada clock ke = " + clockTime;

                    rr.processes.AddRange(sjfDemo);
                }
                tblog.AppendText(Environment.NewLine);
            }


            if (ffDemo.getId() != 0)
            {
                tblog.Text += "Demosi dari Qa ke Qc dengan ID : " + ffDemo.getId() + " pada clock ke = " + clockTime;
                ffDemo.setBurstTime(ffDemo.getBurstTime() + 1);
                sjf.processes.Add(ffDemo);
                tblog.AppendText(Environment.NewLine);
            }
            clockTime++;
        }
		void Form1Load(object sender, EventArgs e)
		{
	
		}
		void Panel1Paint(object sender, PaintEventArgs e)
		{
	
		}
    }
}
