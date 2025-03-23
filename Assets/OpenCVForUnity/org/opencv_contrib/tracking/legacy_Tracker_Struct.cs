
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.TrackingModule
{
    public partial class legacy_Tracker : Algorithm
    {

        //
        // C++:  bool cv::legacy::Tracker::init(Mat image, Rect2d boundingBox)
        //

        /// <summary>
        ///  Initialize the tracker with a known bounding box that surrounded the target
        /// </summary>
        /// <param name="image">
        /// The initial frame
        /// </param>
        /// <param name="boundingBox">
        /// The initial bounding box
        /// </param>
        /// <returns>
        ///  True if initialization went succesfully, false otherwise
        /// </returns>
        public bool init(Mat image, in Vec4d boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();

            return tracking_legacy_1Tracker_init_10(nativeObj, image.nativeObj, boundingBox.Item1, boundingBox.Item2, boundingBox.Item3, boundingBox.Item4);


        }


        //
        // C++:  bool cv::legacy::Tracker::update(Mat image, Rect2d& boundingBox)
        //

        /// <summary>
        ///  Update the tracker, find the new most likely bounding box for the target
        /// </summary>
        /// <param name="image">
        /// The current frame
        /// </param>
        /// <param name="boundingBox">
        /// The bounding box that represent the new target location, if true was returned, not
        ///      modified otherwise
        /// </param>
        /// <returns>
        ///  True means that target was located and false means that tracker cannot locate target in
        ///      current frame. Note, that latter *does not* imply that tracker has failed, maybe target is indeed
        ///      missing from the frame (say, out of sight)
        /// </returns>
        public bool update(Mat image, out Vec4d boundingBox)
        {
            ThrowIfDisposed();
            if (image != null) image.ThrowIfDisposed();
            double[] boundingBox_out = new double[4];
            bool retVal = tracking_legacy_1Tracker_update_10(nativeObj, image.nativeObj, boundingBox_out);
            { boundingBox.Item1 = boundingBox_out[0]; boundingBox.Item2 = boundingBox_out[1]; boundingBox.Item3 = boundingBox_out[2]; boundingBox.Item4 = boundingBox_out[3]; }
            return retVal;
        }

    }
}
