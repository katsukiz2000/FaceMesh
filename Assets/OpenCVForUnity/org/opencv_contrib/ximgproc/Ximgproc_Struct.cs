
using OpenCVForUnity.Calib3dModule;
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.XimgprocModule
{
    public partial class Ximgproc
    {


        //
        // C++:  double cv::ximgproc::computeMSE(Mat GT, Mat src, Rect ROI)
        //

        /// <summary>
        ///  Function for computing mean square error for disparity maps
        /// </summary>
        /// <param name="GT">
        /// ground truth disparity map
        /// </param>
        /// <param name="src">
        /// disparity map to evaluate
        /// </param>
        /// <param name="ROI">
        /// region of interest
        /// </param>
        /// <remarks>
        ///  @result returns mean square error between GT and src
        /// </remarks>
        public static double computeMSE(Mat GT, Mat src, in Vec4i ROI)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeMSE_10(GT.nativeObj, src.nativeObj, ROI.Item1, ROI.Item2, ROI.Item3, ROI.Item4);


        }


        //
        // C++:  double cv::ximgproc::computeBadPixelPercent(Mat GT, Mat src, Rect ROI, int thresh = 24)
        //

        /// <summary>
        ///  Function for computing the percent of "bad" pixels in the disparity map
        ///  (pixels where error is higher than a specified threshold)
        /// </summary>
        /// <param name="GT">
        /// ground truth disparity map
        /// </param>
        /// <param name="src">
        /// disparity map to evaluate
        /// </param>
        /// <param name="ROI">
        /// region of interest
        /// </param>
        /// <param name="thresh">
        /// threshold used to determine "bad" pixels
        /// </param>
        /// <remarks>
        ///  @result returns mean square error between GT and src
        /// </remarks>
        public static double computeBadPixelPercent(Mat GT, Mat src, in Vec4i ROI, int thresh)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeBadPixelPercent_10(GT.nativeObj, src.nativeObj, ROI.Item1, ROI.Item2, ROI.Item3, ROI.Item4, thresh);


        }

        /// <summary>
        ///  Function for computing the percent of "bad" pixels in the disparity map
        ///  (pixels where error is higher than a specified threshold)
        /// </summary>
        /// <param name="GT">
        /// ground truth disparity map
        /// </param>
        /// <param name="src">
        /// disparity map to evaluate
        /// </param>
        /// <param name="ROI">
        /// region of interest
        /// </param>
        /// <param name="thresh">
        /// threshold used to determine "bad" pixels
        /// </param>
        /// <remarks>
        ///  @result returns mean square error between GT and src
        /// </remarks>
        public static double computeBadPixelPercent(Mat GT, Mat src, in Vec4i ROI)
        {
            if (GT != null) GT.ThrowIfDisposed();
            if (src != null) src.ThrowIfDisposed();

            return ximgproc_Ximgproc_computeBadPixelPercent_11(GT.nativeObj, src.nativeObj, ROI.Item1, ROI.Item2, ROI.Item3, ROI.Item4);


        }

    }
}
