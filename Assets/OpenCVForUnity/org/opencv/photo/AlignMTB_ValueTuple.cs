
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.PhotoModule
{
    public partial class AlignMTB : AlignExposures
    {


        //
        // C++:  Point cv::AlignMTB::calculateShift(Mat img0, Mat img1)
        //

        /// <summary>
        ///  Calculates shift between two images, i. e. how to shift the second image to correspond it with the
        ///      first.
        /// </summary>
        /// <param name="img0">
        /// first image
        /// </param>
        /// <param name="img1">
        /// second image
        /// </param>
        public (double x, double y) calculateShiftAsValueTuple(Mat img0, Mat img1)
        {
            ThrowIfDisposed();
            if (img0 != null) img0.ThrowIfDisposed();
            if (img1 != null) img1.ThrowIfDisposed();

            double[] tmpArray = new double[2];
            photo_AlignMTB_calculateShift_10(nativeObj, img0.nativeObj, img1.nativeObj, tmpArray);
            (double x, double y) retVal = (tmpArray[0], tmpArray[1]);

            return retVal;
        }


        //
        // C++:  void cv::AlignMTB::shiftMat(Mat src, Mat& dst, Point shift)
        //

        /// <summary>
        ///  Helper function, that shift Mat filling new regions with zeros.
        /// </summary>
        /// <param name="src">
        /// input image
        /// </param>
        /// <param name="dst">
        /// result image
        /// </param>
        /// <param name="shift">
        /// shift value
        /// </param>
        public void shiftMat(Mat src, Mat dst, in (double x, double y) shift)
        {
            ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();
            if (dst != null) dst.ThrowIfDisposed();

            photo_AlignMTB_shiftMat_10(nativeObj, src.nativeObj, dst.nativeObj, shift.x, shift.y);


        }

    }
}
