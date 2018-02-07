using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conflict_BF1
{
    public static class Drawer
    {
        public static float TopX = 380;
        public static float TopY = 90;
        public static float BottomX = 565;
        public static float BottomY = 305;
        public static float TopWidth = 1160;
        public static float BottomWidth = 788;

        private static float RectangleWidth = 50;
        private static float RectangleHeight = 35;

        public static void DrawOverlay(ref Bitmap bitmap, float x = 0, float y = 0, float topWidth = 0, float bottomWidth = 0, float height = 0) {
            var tX = TopX + x - (topWidth / 2);
            var tY = TopY + y;
            var bX = BottomX + x - (bottomWidth / 2);
            var bY = BottomY + y + height;
            var tWidth = TopWidth + topWidth;
            var bWidth = BottomWidth + bottomWidth;

            // Left line
            Drawer.DrawLineFloat(bitmap, x1: tX, y1: tY, x2: bX, y2: bY, penColor: Color.Silver);
            // Right line
            Drawer.DrawLineFloat(bitmap, x1: (tX + tWidth), y1: tY, x2: (bX + bWidth), y2: bY, penColor: Color.Silver);

            // Create red rectangles
            #region RED
            float lastPos = tX;
            int loopCount = 8;
            for (int i = 0; i < loopCount; i++) {
                var width = (tWidth - (2 * RectangleWidth)) / 6;
                // If first or last rectangle
                if (i == 0 || i == (loopCount - 1)) {
                    width = RectangleWidth;
                    Drawer.DrawRectangle(bitmap, x: lastPos, y: tY, width: RectangleWidth, height: RectangleHeight, penColor: Color.Red);
                }
                else {
                    Drawer.DrawRectangle(bitmap, x: lastPos, y: tY, width: width, height: RectangleHeight, penColor: Color.Red);
                }
                lastPos += width;
            }
            #endregion

            // Create orange rectangles
            #region ORANGE
            lastPos = tX + ((bX - tX) / 3);
            loopCount = 6;
            for (int i = 0; i < loopCount; i++) {
                var width = ((((tX + tWidth) - ((bX - tX) / 3)) - (tX + ((bX - tX) / 3))) - (2 * RectangleWidth)) / 4;
                // If first or last rectangle
                if (i == 0 || i == (loopCount - 1)) {
                    width = RectangleWidth;
                    Drawer.DrawRectangle(bitmap, x: lastPos, y: tY - ((tY - bY) / 3), width: RectangleWidth, height: RectangleHeight, penColor: Color.Orange);
                }
                else {
                    Drawer.DrawRectangle(bitmap, x: lastPos, y: tY - ((tY - bY) / 3), width: width, height: RectangleHeight, penColor: Color.Orange);
                }
                lastPos += width;
            }
            #endregion

            // Create yellow rectangles
            #region YELLOW
            lastPos = bX - ((bX - tX) / 3);
            loopCount = 4;
            for (int i = 0; i < loopCount; i++) {
                var width = ((((tX + tWidth) - (((bX - tX) / 3) * 2)) - (bX - ((bX - tX) / 3))) - (2 * RectangleWidth)) / 2;
                // If first or last rectangle
                if (i == 0 || i == (loopCount - 1)) {
                    width = RectangleWidth;
                    Drawer.DrawRectangle(bitmap, x: lastPos, y: bY + ((tY - bY) / 3), width: RectangleWidth, height: RectangleHeight, penColor: Color.Yellow);
                }
                else {
                    Drawer.DrawRectangle(bitmap, x: lastPos, y: bY + ((tY - bY) / 3), width: width, height: RectangleHeight, penColor: Color.Yellow);
                }
                lastPos += width;
            }
            #endregion

            // Create green rectangles
            #region GREEN
            Drawer.DrawRectangle(bitmap, x: bX, y: bY, width: (bWidth / 2), height: RectangleHeight * 2, penColor: Color.Green);
            Drawer.DrawRectangle(bitmap, x: bX + (bWidth / 2), y: bY, width: (bWidth / 2), height: RectangleHeight * 2, penColor: Color.Green); 
            #endregion

            // Bottom line
            Drawer.DrawLineFloat(bitmap, x1: bX, y1: bY, x2: (bX + bWidth), y2: bY, penColor: Color.Green);
        }

        public static void DrawOverlay_Old(ref Bitmap bitmap, int xPlus = 0, int yPlus = 0) {
            // Left line
            Drawer.DrawLineFloat(bitmap, x1: 380 - xPlus, y1: 60 + yPlus, x2: 580 - xPlus, y2: 300 + yPlus, penColor: Color.Black);
            // Right line
            Drawer.DrawLineFloat(bitmap, x1: 1540 + xPlus, y1: 60 + yPlus, x2: 1340 + xPlus, y2: 300 + yPlus, penColor: Color.Black);

            // Red top line
            Drawer.DrawLineFloat(bitmap, x1: 380 - xPlus, y1: 60 + yPlus, x2: 1540 + xPlus, y2: 60 + yPlus, penColor: Color.Red);
            // Red bottom line
            Drawer.DrawLineFloat(bitmap, x1: 410 - xPlus, y1: 96 + yPlus, x2: 1510 + xPlus, y2: 96 + yPlus, penColor: Color.Red);
            // Red left line
            Drawer.DrawLineFloat(bitmap, x1: 380 - xPlus, y1: 60 + yPlus, x2: 410 - xPlus, y2: 96 + yPlus, penColor: Color.Red);
            // Red right line
            Drawer.DrawLineFloat(bitmap, x1: 1540 + xPlus, y1: 60 + yPlus, x2: 1510 + xPlus, y2: 96 + yPlus, penColor: Color.Red);
            // Red left rectangle
            Drawer.DrawRectangle(bitmap, x: 380 - xPlus, y: 60 + yPlus, width: 50, height: 35, penColor: Color.Red);
            // Red left 1 rectangle
            Drawer.DrawRectangle(bitmap, x: 430 - xPlus, y: 60 + yPlus, width: 180, height: 35, penColor: Color.Red);
            // Red left 2 rectangle
            Drawer.DrawRectangle(bitmap, x: 610 - xPlus, y: 60 + yPlus, width: 175, height: 35, penColor: Color.Red);
            // Red left 3 rectangle
            Drawer.DrawRectangle(bitmap, x: 785 - xPlus, y: 60 + yPlus, width: 175, height: 35, penColor: Color.Red);
            // Red right 3 rectangle
            Drawer.DrawRectangle(bitmap, x: 960 - xPlus, y: 60 + yPlus, width: 175, height: 35, penColor: Color.Red);
            // Red right 2 rectangle
            Drawer.DrawRectangle(bitmap, x: 1135 - xPlus, y: 60 + yPlus, width: 175, height: 35, penColor: Color.Red);
            // Red right 1 rectangle
            Drawer.DrawRectangle(bitmap, x: 1310 - xPlus, y: 60 + yPlus, width: 180, height: 35, penColor: Color.Red);
            // Red right rectangle
            Drawer.DrawRectangle(bitmap, x: 1490 - xPlus, y: 60 + yPlus, width: 50, height: 35, penColor: Color.Red);

            // Orange top line
            Drawer.DrawLineFloat(bitmap, x1: 440 - xPlus, y1: 130 + yPlus, x2: 1480 + xPlus, y2: 130 + yPlus, penColor: Color.Orange);
            // Orange bottom line
            Drawer.DrawLineFloat(bitmap, x1: 470 - xPlus, y1: 165 + yPlus, x2: 1450 + xPlus, y2: 165 + yPlus, penColor: Color.Orange);
            // Orange left line
            Drawer.DrawLineFloat(bitmap, x1: 440 - xPlus, y1: 130 + yPlus, x2: 470 + xPlus, y2: 165 + yPlus, penColor: Color.Orange);
            // Orange right line
            Drawer.DrawLineFloat(bitmap, x1: 1480 - xPlus, y1: 130 + yPlus, x2: 1450 + xPlus, y2: 165 + yPlus, penColor: Color.Orange);
            // Orange left rectangle
            Drawer.DrawRectangle(bitmap, x: 440 - xPlus, y: 130 + yPlus, width: 50, height: 35, penColor: Color.Orange);
            // Orange left 1 rectangle
            Drawer.DrawRectangle(bitmap, x: 490 - xPlus, y: 130 + yPlus, width: 235, height: 35, penColor: Color.Orange);
            // Orange left 2 rectangle
            Drawer.DrawRectangle(bitmap, x: 725 - xPlus, y: 130 + yPlus, width: 235, height: 35, penColor: Color.Orange);
            // Orange right 2 rectangle
            Drawer.DrawRectangle(bitmap, x: 960 - xPlus, y: 130 + yPlus, width: 235, height: 35, penColor: Color.Orange);
            // Orange right 1 rectangle
            Drawer.DrawRectangle(bitmap, x: 1195 - xPlus, y: 130 + yPlus, width: 235, height: 35, penColor: Color.Orange);
            // Orange right rectangle
            Drawer.DrawRectangle(bitmap, x: 1430 - xPlus, y: 130 + yPlus, width: 50, height: 35, penColor: Color.Orange);

            // Yellow top line
            Drawer.DrawLineFloat(bitmap, x1: 500 - xPlus, y1: 203 + yPlus, x2: 1420 + xPlus, y2: 203 + yPlus, penColor: Color.Yellow);
            // Yellow bottom line
            Drawer.DrawLineFloat(bitmap, x1: 530 - xPlus, y1: 238 + yPlus, x2: 1390 + xPlus, y2: 238 + yPlus, penColor: Color.Yellow);
            // Yellow left line
            Drawer.DrawLineFloat(bitmap, x1: 500 - xPlus, y1: 203 + yPlus, x2: 530 + xPlus, y2: 238 + yPlus, penColor: Color.Yellow);
            // Yellow right line
            Drawer.DrawLineFloat(bitmap, x1: 1420 - xPlus, y1: 203 + yPlus, x2: 1390 + xPlus, y2: 238 + yPlus, penColor: Color.Yellow);
            // Yellow left rectangle
            Drawer.DrawRectangle(bitmap, x: 500 - xPlus, y: 203 + yPlus, width: 50, height: 35, penColor: Color.Yellow);
            // Yellow Center line
            Drawer.DrawLineFloat(bitmap, x1: 960 - xPlus, y1: 203 + yPlus, x2: 960 + xPlus, y2: 238 + yPlus, penColor: Color.Yellow);
            // Yellow right rectangle
            Drawer.DrawRectangle(bitmap, x: 1370 - xPlus, y: 203 + yPlus, width: 50, height: 35, penColor: Color.Yellow);

            // Bottom line
            Drawer.DrawLineFloat(bitmap, x1: 580 - xPlus, y1: 300 + yPlus, x2: 1340 + xPlus, y2: 300 + yPlus, penColor: Color.Green);
        }

        public static Bitmap DrawOverlay() {
            var bMap = new Bitmap(1920, 1080, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            // Left line
            Drawer.DrawLineFloat(bMap, x1: 380, y1: 60, x2: 580, y2: 300, penColor: Color.Black);
            // Right line
            Drawer.DrawLineFloat(bMap, x1: 1540, y1: 60, x2: 1340, y2: 300, penColor: Color.Black);

            // Red top line
            Drawer.DrawLineFloat(bMap, x1: 380, y1: 60, x2: 1540, y2: 60, penColor: Color.Red);
            // Red bottom line
            Drawer.DrawLineFloat(bMap, x1: 410, y1: 96, x2: 1510, y2: 96, penColor: Color.Red);
            // Red left line
            Drawer.DrawLineFloat(bMap, x1: 380, y1: 60, x2: 410, y2: 96, penColor: Color.Red);
            // Red right line
            Drawer.DrawLineFloat(bMap, x1: 1540, y1: 60, x2: 1510, y2: 96, penColor: Color.Red);
            // Red left rectangle
            Drawer.DrawRectangle(bMap, x: 380, y: 60, width: 50, height: 35, penColor: Color.Red);
            // Red left 1 rectangle
            Drawer.DrawRectangle(bMap, x: 430, y: 60, width: 180, height: 35, penColor: Color.Red);
            // Red left 2 rectangle
            Drawer.DrawRectangle(bMap, x: 610, y: 60, width: 175, height: 35, penColor: Color.Red);
            // Red left 3 rectangle
            Drawer.DrawRectangle(bMap, x: 785, y: 60, width: 175, height: 35, penColor: Color.Red);
            // Red right 3 rectangle
            Drawer.DrawRectangle(bMap, x: 960, y: 60, width: 175, height: 35, penColor: Color.Red);
            // Red right 2 rectangle
            Drawer.DrawRectangle(bMap, x: 1135, y: 60, width: 175, height: 35, penColor: Color.Red);
            // Red right 1 rectangle
            Drawer.DrawRectangle(bMap, x: 1310, y: 60, width: 180, height: 35, penColor: Color.Red);
            // Red right rectangle
            Drawer.DrawRectangle(bMap, x: 1490, y: 60, width: 50, height: 35, penColor: Color.Red);

            // Orange top line
            Drawer.DrawLineFloat(bMap, x1: 440, y1: 130, x2: 1480, y2: 130, penColor: Color.Orange);
            // Orange bottom line
            Drawer.DrawLineFloat(bMap, x1: 470, y1: 165, x2: 1450, y2: 165, penColor: Color.Orange);
            // Orange left line
            Drawer.DrawLineFloat(bMap, x1: 440, y1: 130, x2: 470, y2: 165, penColor: Color.Orange);
            // Orange right line
            Drawer.DrawLineFloat(bMap, x1: 1480, y1: 130, x2: 1450, y2: 165, penColor: Color.Orange);
            // Orange left rectangle
            Drawer.DrawRectangle(bMap, x: 440, y: 130, width: 50, height: 35, penColor: Color.Orange);
            // Orange left 1 rectangle
            Drawer.DrawRectangle(bMap, x: 490, y: 130, width: 235, height: 35, penColor: Color.Orange);
            // Orange left 2 rectangle
            Drawer.DrawRectangle(bMap, x: 725, y: 130, width: 235, height: 35, penColor: Color.Orange);
            // Orange right 2 rectangle
            Drawer.DrawRectangle(bMap, x: 960, y: 130, width: 235, height: 35, penColor: Color.Orange);
            // Orange right 1 rectangle
            Drawer.DrawRectangle(bMap, x: 1195, y: 130, width: 235, height: 35, penColor: Color.Orange);
            // Orange right rectangle
            Drawer.DrawRectangle(bMap, x: 1430, y: 130, width: 50, height: 35, penColor: Color.Orange);

            // Yellow top line
            Drawer.DrawLineFloat(bMap, x1: 500, y1: 203, x2: 1420, y2: 203, penColor: Color.Yellow);
            // Yellow bottom line
            Drawer.DrawLineFloat(bMap, x1: 530, y1: 238, x2: 1390, y2: 238, penColor: Color.Yellow);
            // Yellow left line
            Drawer.DrawLineFloat(bMap, x1: 500, y1: 203, x2: 530, y2: 238, penColor: Color.Yellow);
            // Yellow right line
            Drawer.DrawLineFloat(bMap, x1: 1420, y1: 203, x2: 1390, y2: 238, penColor: Color.Yellow);
            // Yellow left rectangle
            Drawer.DrawRectangle(bMap, x: 500, y: 203, width: 50, height: 35, penColor: Color.Yellow);
            // Yellow Center line
            Drawer.DrawLineFloat(bMap, x1: 960, y1: 203, x2: 960, y2: 238, penColor: Color.Yellow);
            // Yellow right rectangle
            Drawer.DrawRectangle(bMap, x: 1370, y: 203, width: 50, height: 35, penColor: Color.Yellow);

            // Bottom line
            Drawer.DrawLineFloat(bMap, x1: 580, y1: 300, x2: 1340, y2: 300, penColor: Color.Green);
            return (bMap);
        }

        public static void DrawDotFloat(Bitmap bmp, float x1, float y1, Brush brushColor) {
            // Draw line to screen.
            using (var graphics = Graphics.FromImage(bmp)) {
                graphics.FillRectangle(brushColor, x1, y1, 5, 5);
            }
        }

        public static void DrawLineFloat(Bitmap bmp, float x1, float y1, float x2, float y2, Color penColor) {
            Pen blackPen = new Pen(penColor, 3);

            // Draw line to screen.
            using (var graphics = Graphics.FromImage(bmp)) {
                graphics.DrawLine(blackPen, x1, y1, x2, y2);
            }
        }

        public static void DrawRectangle(Bitmap bmp, float x, float y, float width, float height, Color penColor) {
            Pen blackPen = new Pen(penColor, 3);

            // Draw line to screen.
            using (var graphics = Graphics.FromImage(bmp)) {
                graphics.DrawRectangle(blackPen, x, y, width, height);
            }
        }

        public static Bitmap OverlapTwoImages(Image firstImage, Image secondImage) {
            if (firstImage == null) {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null) {
                throw new ArgumentNullException("secondImage");
            }

            Bitmap outputImage = new Bitmap(firstImage.Width, firstImage.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage)) {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        public static Bitmap MergeTwoImages(Image firstImage, Image secondImage) {
            if (firstImage == null) {
                throw new ArgumentNullException("firstImage");
            }

            if (secondImage == null) {
                throw new ArgumentNullException("secondImage");
            }

            int outputImageWidth = firstImage.Width > secondImage.Width ? firstImage.Width : secondImage.Width;

            int outputImageHeight = firstImage.Height + secondImage.Height + 1;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage)) {
                graphics.DrawImage(firstImage, new Rectangle(new Point(), firstImage.Size),
                    new Rectangle(new Point(), firstImage.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(secondImage, new Rectangle(new Point(0, firstImage.Height + 1), secondImage.Size),
                    new Rectangle(new Point(), secondImage.Size), GraphicsUnit.Pixel);
            }

            return outputImage;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <param name="width">The width to resize to.</param>
        /// <param name="height">The height to resize to.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Image image, int width, int height, int x = 0, int y = 0) {
            var destRect = new Rectangle(x, y, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
