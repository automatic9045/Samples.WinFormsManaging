using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samples.WinFormsManaging
{
    public class SampleClass
    {
        // Formのインスタンスは何かしらの形で渡しておかないといけない
        // 今回はコンストラクタの引数で渡す形にした
        private SampleForm form;

        public SampleClass(SampleForm form)
        {
            this.form = form;
        }

        // デザイナーを使った場合、コントロールはprivateなフィールドとして登録されてしまうので外部から直接参照出来ない
        // 外部から参照するために、名前からコントロールを絞るメソッドが用意されている
        public void SetTextByControlFind(string text)
        {
            TextBox textBox = (TextBox)form.Controls.Find("textBox1", true)[0];
            textBox.Text = text;
        }

        // プロパティ（フィールドでもできはするが、非推奨）で公開する手もある
        public void SetTextByProperty(string text)
        {
            TextBox textBox = form.TextBox2;
            textBox.Text = text;
        }
    }
}
