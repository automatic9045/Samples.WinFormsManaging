using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.WinFormsManaging
{
    public partial class SampleForm : Form
    {
        public TextBox TextBox2 { get; }

        private SampleClass sampleClass;

        public SampleForm()
        {
            InitializeComponent();
            sampleClass = new SampleClass(this);

            button1.Click += (sender, e) => sampleClass.SetTextByControlFind("hoge");

            TextBox2 = textBox2; // 基本型以外のクラスは参照型なので、TextBox2はtextBox2と同じものを参照するようになる
            button2.Click += (sender, e) => sampleClass.SetTextByProperty("fuga");
        }
    }
}
