namespace MyBusinessCard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            // 0~255 사이의R, G, B 값을무작위로생성하여배경색에적용
            this.BackColor = Color.FromArgb(rd.Next(256), rd.Next(256), rd.Next(256));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/coddddin/CS_Week01_22017004_KangHeejun";
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Microsoft/Edge/Application/msedge.exe", url);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 실행 폴더의 2.png를 로드하여 PictureBox 이미지로 설정
            pictureBox1.Image = System.Drawing.Image.FromFile("2.png");
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // 마우스가 사진 위로 올라오면 테두리 스타일을 변경 (상시 효과)
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            // 마우스가 사진에서 떠나면 테두리 제거
            pictureBox1.BorderStyle = BorderStyle.None;
        }
    }
}
