
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{
    public partial class legacy_MultiTracker : Algorithm
    {


        //
        // C++:  bool cv::legacy::MultiTracker::add(Ptr_legacy_Tracker newTracker, Mat image, Rect2d boundingBox)
        //

        /// <remarks>
        ///    \brief Add a new object to be tracked.
        /// </remarks>
        /// <param name="newTracker">
        /// tracking algorithm to be used
        /// </param>
        /// <param name="image">
        /// input image
        /// </param>
        /// <param name="boundingBox">
        /// a rectangle represents ROI of the tracked object
        /// </param>
        public bool add(legacy_Tracker newTracker, Mat image, in Vec4d boundingBox)
        {
            ThrowIfDisposed();
            if (newTracker != null) newTracker.ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return tracking_legacy_1MultiTracker_add_10(nativeObj, newTracker.getNativeObjAddr(), image.nativeObj, boundingBox.Item1, boundingBox.Item2, boundingBox.Item3, boundingBox.Item4);


        }

    }
}
