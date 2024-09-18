using System.Drawing;

namespace Optical_Character_Recogniter
{
    public class Area
    {
        private Point startPoint;
        private Rectangle selectionRect;
        private bool isSelecting;
        private bool hasSelecting;

        // 選択開始点をセット
        public void StartSelection(Point start)
        {
            startPoint = start;
            isSelecting = true;
            hasSelecting = false;
        }

        // 現在のマウスの位置で選択範囲を更新
        public void UpdateSelection(Point currentPoint)
        {
            if (isSelecting)
            {
                int width = currentPoint.X - startPoint.X;
                int height = currentPoint.Y - startPoint.Y;
                selectionRect = new Rectangle(startPoint.X, startPoint.Y, width, height);
            }
        }

        // 選択範囲を確定し、Rectangleを返す
        public Rectangle EndSelection()
        {
            isSelecting = false;
            hasSelecting = true;
            return selectionRect;
        }

        // 選択範囲を描画
        public void DrawSelection(Graphics g)
        {
            if (selectionRect != Rectangle.Empty)
            {
                using (Pen pen = new Pen(Color.Red, 2)) // 赤い枠を描画
                {
                    g.DrawRectangle(pen, selectionRect);
                }
            }
        }
    }
}
