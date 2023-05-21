using CommandCommand;
using CommandDrawer;

namespace Command
{
    public partial class DrawCanvas : UserControl, IDrawable
    {
        public DrawCanvas()
        {
            InitializeComponent();
        }

        private Color _color = Color.Red;
        private int _radius = 6;
        private MacroCommand _history;

        public void Draw(int x, int y)
        {
            using (var g = CreateGraphics())
            using (var brush = new SolidBrush(_color))
            {
                g.FillEllipse(brush, x - _radius, y - _radius, _radius * 2, _radius * 2);
            }
        }

        // �{���̓R���X�g���N�^�ōs�Ȃ������B
        // �������p���\�b�h
        public void SetHistory(MacroCommand history)
        {
            _history = history;
        }

        // ���ꂪ�����ƁA�ŏ�������߂����Ƃ��ȂǂɁA�ĕ`�悳��Ȃ��B
        private void DrawCanvas_Paint(object sender, PaintEventArgs e)
        {
            if (_history != null)
            {
                _history.Execute();
            }
        }
    }
}
