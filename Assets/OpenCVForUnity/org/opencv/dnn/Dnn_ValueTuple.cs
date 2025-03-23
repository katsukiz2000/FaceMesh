#if !UNITY_WSA_10_0

using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.DnnModule
{
    public partial class Dnn
    {


        //
        // C++:  Mat cv::dnn::blobFromImage(Mat image, double scalefactor = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false, int ddepth = CV_32F)
        //

        /// <summary>
        ///  Creates 4-dimensional blob from image. Optionally resizes and crops @p image from center,
        ///          subtract @p mean values, scales values by @p scalefactor, swap Blue and Red channels.
        /// </summary>
        /// <param name="image">
        /// input image (with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImage(Mat image, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean, bool swapRB, bool crop, int ddepth)
        {
            if (image != null) image.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImage_10(image.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3, swapRB, crop, ddepth)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from image. Optionally resizes and crops @p image from center,
        ///          subtract @p mean values, scales values by @p scalefactor, swap Blue and Red channels.
        /// </summary>
        /// <param name="image">
        /// input image (with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImage(Mat image, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean, bool swapRB, bool crop)
        {
            if (image != null) image.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImage_11(image.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3, swapRB, crop)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from image. Optionally resizes and crops @p image from center,
        ///          subtract @p mean values, scales values by @p scalefactor, swap Blue and Red channels.
        /// </summary>
        /// <param name="image">
        /// input image (with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImage(Mat image, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean, bool swapRB)
        {
            if (image != null) image.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImage_12(image.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3, swapRB)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from image. Optionally resizes and crops @p image from center,
        ///          subtract @p mean values, scales values by @p scalefactor, swap Blue and Red channels.
        /// </summary>
        /// <param name="image">
        /// input image (with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImage(Mat image, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean)
        {
            if (image != null) image.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImage_13(image.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from image. Optionally resizes and crops @p image from center,
        ///          subtract @p mean values, scales values by @p scalefactor, swap Blue and Red channels.
        /// </summary>
        /// <param name="image">
        /// input image (with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImage(Mat image, double scalefactor, in (double width, double height) size)
        {
            if (image != null) image.ThrowIfDisposed();

            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImage_14(image.nativeObj, scalefactor, size.width, size.height)));


        }


        //
        // C++:  Mat cv::dnn::blobFromImages(vector_Mat images, double scalefactor = 1.0, Size size = Size(), Scalar mean = Scalar(), bool swapRB = false, bool crop = false, int ddepth = CV_32F)
        //

        /// <summary>
        ///  Creates 4-dimensional blob from series of images. Optionally resizes and
        ///          crops @p images from center, subtract @p mean values, scales values by @p scalefactor,
        ///          swap Blue and Red channels.
        /// </summary>
        /// <param name="images">
        /// input images (all with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImages(List<Mat> images, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean, bool swapRB, bool crop, int ddepth)
        {

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImages_10(images_mat.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3, swapRB, crop, ddepth)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from series of images. Optionally resizes and
        ///          crops @p images from center, subtract @p mean values, scales values by @p scalefactor,
        ///          swap Blue and Red channels.
        /// </summary>
        /// <param name="images">
        /// input images (all with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImages(List<Mat> images, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean, bool swapRB, bool crop)
        {

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImages_11(images_mat.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3, swapRB, crop)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from series of images. Optionally resizes and
        ///          crops @p images from center, subtract @p mean values, scales values by @p scalefactor,
        ///          swap Blue and Red channels.
        /// </summary>
        /// <param name="images">
        /// input images (all with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImages(List<Mat> images, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean, bool swapRB)
        {

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImages_12(images_mat.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3, swapRB)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from series of images. Optionally resizes and
        ///          crops @p images from center, subtract @p mean values, scales values by @p scalefactor,
        ///          swap Blue and Red channels.
        /// </summary>
        /// <param name="images">
        /// input images (all with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImages(List<Mat> images, double scalefactor, in (double width, double height) size, in (double v0, double v1, double v2, double v3) mean)
        {

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImages_13(images_mat.nativeObj, scalefactor, size.width, size.height, mean.v0, mean.v1, mean.v2, mean.v3)));


        }

        /// <summary>
        ///  Creates 4-dimensional blob from series of images. Optionally resizes and
        ///          crops @p images from center, subtract @p mean values, scales values by @p scalefactor,
        ///          swap Blue and Red channels.
        /// </summary>
        /// <param name="images">
        /// input images (all with 1-, 3- or 4-channels).
        /// </param>
        /// <param name="size">
        /// spatial size for output image
        /// </param>
        /// <param name="mean">
        /// scalar with mean values which are subtracted from channels. Values are intended
        ///          to be in (mean-R, mean-G, mean-B) order if @p image has BGR ordering and @p swapRB is true.
        /// </param>
        /// <param name="scalefactor">
        /// multiplier for @p images values.
        /// </param>
        /// <param name="swapRB">
        /// flag which indicates that swap first and last channels
        ///          in 3-channel image is necessary.
        /// </param>
        /// <param name="crop">
        /// flag which indicates whether image will be cropped after resize or not
        /// </param>
        /// <param name="ddepth">
        /// Depth of output blob. Choose CV_32F or CV_8U.
        ///          @details if @p crop is true, input image is resized so one side after resize is equal to corresponding
        ///          dimension in @p size and another one is equal or larger. Then, crop from the center is performed.
        ///          If @p crop is false, direct resize without cropping and preserving aspect ratio is performed.
        /// </param>
        /// <returns>
        ///  4-dimensional Mat with NCHW dimensions order.
        /// </returns>
        /// <remarks>
        ///         @note
        ///         The order and usage of `scalefactor` and `mean` are (input - mean) * scalefactor.
        /// </remarks>
        public static Mat blobFromImages(List<Mat> images, double scalefactor, in (double width, double height) size)
        {

            Mat images_mat = Converters.vector_Mat_to_Mat(images);
            return new Mat(DisposableObject.ThrowIfNullIntPtr(dnn_Dnn_blobFromImages_14(images_mat.nativeObj, scalefactor, size.width, size.height)));


        }

    }
}

#endif