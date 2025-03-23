
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{
    public partial class FastLineDetector : Algorithm
    {


        //
        // C++:  void cv::ximgproc::FastLineDetector::drawSegments(Mat& image, Mat lines, bool draw_arrow = false, Scalar linecolor = Scalar(0, 0, 255), int linethickness = 1)
        //

        /// <summary>
        ///  Draws the line segments on a given image.
        /// </summary>
        /// <param name="image">
        /// The image, where the lines will be drawn. Should be bigger
        ///        or equal to the image, where the lines were found.
        /// </param>
        /// <param name="lines">
        /// A vector of the lines that needed to be drawn.
        /// </param>
        /// <param name="draw_arrow">
        /// If true, arrow heads will be drawn.
        /// </param>
        /// <param name="linecolor">
        /// Line color.
        /// </param>
        /// <param name="linethickness">
        /// Line thickness.
        /// </param>
        public void drawSegments(Mat image, Mat lines, bool draw_arrow, in Vec4d linecolor, int linethickness)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();

            ximgproc_FastLineDetector_drawSegments_10(nativeObj, image.nativeObj, lines.nativeObj, draw_arrow, linecolor.Item1, linecolor.Item2, linecolor.Item3, linecolor.Item4, linethickness);


        }

        /// <summary>
        ///  Draws the line segments on a given image.
        /// </summary>
        /// <param name="image">
        /// The image, where the lines will be drawn. Should be bigger
        ///        or equal to the image, where the lines were found.
        /// </param>
        /// <param name="lines">
        /// A vector of the lines that needed to be drawn.
        /// </param>
        /// <param name="draw_arrow">
        /// If true, arrow heads will be drawn.
        /// </param>
        /// <param name="linecolor">
        /// Line color.
        /// </param>
        /// <param name="linethickness">
        /// Line thickness.
        /// </param>
        public void drawSegments(Mat image, Mat lines, bool draw_arrow, in Vec4d linecolor)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            if (lines != null) lines.ThrowIfDisposed();

            ximgproc_FastLineDetector_drawSegments_11(nativeObj, image.nativeObj, lines.nativeObj, draw_arrow, linecolor.Item1, linecolor.Item2, linecolor.Item3, linecolor.Item4);


        }

    }
}
