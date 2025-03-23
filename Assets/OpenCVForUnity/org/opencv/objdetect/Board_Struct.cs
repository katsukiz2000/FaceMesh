

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.ObjdetectModule
{
    public partial class Board : DisposableOpenCVObject
    {


        //
        // C++:  Point3f cv::aruco::Board::getRightBottomCorner()
        //

        /// <summary>
        ///  get coordinate of the bottom right corner of the board, is set when calling the function create()
        /// </summary>
        public Vec3d getRightBottomCornerAsVec3d()
        {
            ThrowIfDisposed();

            double[] tmpArray = new double[3];
            objdetect_Board_getRightBottomCorner_10(nativeObj, tmpArray);
            Vec3d retVal = new Vec3d(tmpArray[0], tmpArray[1], tmpArray[2]);

            return retVal;
        }


        //
        // C++:  void cv::aruco::Board::generateImage(Size outSize, Mat& img, int marginSize = 0, int borderBits = 1)
        //

        /// <summary>
        ///  Draw a planar board
        /// </summary>
        /// <param name="outSize">
        /// size of the output image in pixels.
        /// </param>
        /// <param name="img">
        /// output image with the board. The size of this image will be outSize
        ///         and the board will be on the center, keeping the board proportions.
        /// </param>
        /// <param name="marginSize">
        /// minimum margins (in pixels) of the board in the output image
        /// </param>
        /// <param name="borderBits">
        /// width of the marker borders.
        /// </param>
        /// <remarks>
        ///         This function return the image of the board, ready to be printed.
        /// </remarks>
        public void generateImage(in Vec2d outSize, Mat img, int marginSize, int borderBits)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            objdetect_Board_generateImage_10(nativeObj, outSize.Item1, outSize.Item2, img.nativeObj, marginSize, borderBits);


        }

        /// <summary>
        ///  Draw a planar board
        /// </summary>
        /// <param name="outSize">
        /// size of the output image in pixels.
        /// </param>
        /// <param name="img">
        /// output image with the board. The size of this image will be outSize
        ///         and the board will be on the center, keeping the board proportions.
        /// </param>
        /// <param name="marginSize">
        /// minimum margins (in pixels) of the board in the output image
        /// </param>
        /// <param name="borderBits">
        /// width of the marker borders.
        /// </param>
        /// <remarks>
        ///         This function return the image of the board, ready to be printed.
        /// </remarks>
        public void generateImage(in Vec2d outSize, Mat img, int marginSize)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            objdetect_Board_generateImage_11(nativeObj, outSize.Item1, outSize.Item2, img.nativeObj, marginSize);


        }

        /// <summary>
        ///  Draw a planar board
        /// </summary>
        /// <param name="outSize">
        /// size of the output image in pixels.
        /// </param>
        /// <param name="img">
        /// output image with the board. The size of this image will be outSize
        ///         and the board will be on the center, keeping the board proportions.
        /// </param>
        /// <param name="marginSize">
        /// minimum margins (in pixels) of the board in the output image
        /// </param>
        /// <param name="borderBits">
        /// width of the marker borders.
        /// </param>
        /// <remarks>
        ///         This function return the image of the board, ready to be printed.
        /// </remarks>
        public void generateImage(in Vec2d outSize, Mat img)
        {
            ThrowIfDisposed();
            if (img != null) img.ThrowIfDisposed();

            objdetect_Board_generateImage_12(nativeObj, outSize.Item1, outSize.Item2, img.nativeObj);


        }

    }
}
