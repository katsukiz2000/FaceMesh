
using OpenCVForUnity.CoreModule;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UtilsModule;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity.Features2dModule
{
    public partial class BOWKMeansTrainer : BOWTrainer
    {

        //
        // C++:   cv::BOWKMeansTrainer::BOWKMeansTrainer(int clusterCount, TermCriteria termcrit = TermCriteria(), int attempts = 3, int flags = KMEANS_PP_CENTERS)
        //

        /// <summary>
        ///  The constructor.
        /// </summary>
        /// <remarks>
        ///      @see cv::kmeans
        /// </remarks>
        public BOWKMeansTrainer(int clusterCount, in Vec3d termcrit, int attempts, int flags) :
                    base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_10(clusterCount, (int)termcrit.Item1, (int)termcrit.Item2, termcrit.Item3, attempts, flags)))
        {



        }

        /// <summary>
        ///  The constructor.
        /// </summary>
        /// <remarks>
        ///      @see cv::kmeans
        /// </remarks>
        public BOWKMeansTrainer(int clusterCount, in Vec3d termcrit, int attempts) :
                    base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_11(clusterCount, (int)termcrit.Item1, (int)termcrit.Item2, termcrit.Item3, attempts)))
        {



        }

        /// <summary>
        ///  The constructor.
        /// </summary>
        /// <remarks>
        ///      @see cv::kmeans
        /// </remarks>
        public BOWKMeansTrainer(int clusterCount, in Vec3d termcrit) :
                    base(DisposableObject.ThrowIfNullIntPtr(features2d_BOWKMeansTrainer_BOWKMeansTrainer_12(clusterCount, (int)termcrit.Item1, (int)termcrit.Item2, termcrit.Item3)))
        {



        }

    }
}
