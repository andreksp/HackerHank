using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.CrackingCodeInterview
{
    public class CountingInversions
    {
        public static void Run()
        {
            //int t = Convert.ToInt32(Console.ReadLine());
            //for (int a0 = 0; a0 < t; a0++)
            //{
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    string[] arr_temp = Console.ReadLine().Split(' ');
            //    int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            //    long result = countInversions(arr);
            //    Console.WriteLine(result);
            //}

            //countInversions(new int[] { 2, 4, 5, 7, 9, 10, 1, 3, 6, 8, 11});
            //countInversions(new int[] { 10, 5, 2, 7, 4, 9, 12, 1, 8, 6, 11, 3 });
            //countInversions(new int[] { 38, 27, 43, 3, 9, 82, 10 });
            //countInversions(new int[] { 2, 1, 3, 1, 2 });

            int[] arr = new int[] { 2, 1, 3, 1, 2 };
            var ret =  mergeSort(arr, 5);

            //countInversions(new int[] { 930887, 692778, 636916, 747794, 238336, 885387, 760493, 516650, 641422, 202363, 490028, 368691, 520060, 897764, 513927, 180541, 383427, 89173, 455737, 5212, 595369, 702568, 956430, 465783, 21531, 722863, 665124, 174068, 703136, 513930, 979803, 634023, 723059, 133070, 898168, 961394, 18457, 175012, 478043, 176230, 377374, 484422, 544920, 413785, 898538, 575199, 594325, 798316, 664371, 566414, 803527, 776092, 268981, 759957, 241874, 806863, 999171, 906997, 497282, 702306, 420926, 477085, 336328, 660337, 126506, 750847, 621730, 661314, 925858, 616125, 353896, 819583, 100546, 898815, 233368, 515435, 990365, 344044, 313751, 171088, 426809, 117277, 947179, 695789, 393585, 705404, 502652, 392755, 612400, 999933, 95061, 549677, 993369, 947740, 210013, 636227, 698587, 348095, 297540, 140796, 480571, 651435, 960379, 97468, 66602, 710098, 612903, 573318, 570493, 926653, 260757, 997302, 560281, 724287, 209442, 953866, 429690, 228445, 346620, 558441, 744730, 958032, 108118, 738098, 905772, 834482, 890676, 120710, 698928, 704568, 777857, 179498, 872354, 254587, 276966, 455307, 964684, 406220, 28625, 51529, 332872, 805733, 48830, 409504, 530020, 258271, 363369, 959709, 486716, 226341, 518150, 747797, 700724, 142619, 2246, 122847, 493452, 892922, 243556, 192380, 597489, 537765, 888229, 469842, 792351, 165194, 441501, 757035, 87765, 470125, 324915, 936988, 275857, 373744, 346492, 322228, 148366, 709860, 281937, 151433, 452552, 316438, 899229, 153276, 975408, 901475, 276122, 468859, 794396, 36030, 661238, 908236, 573794, 65819, 894429, 366144, 231012, 335929, 639530, 318777, 322405, 964444, 255764, 114614, 854539, 118607, 436841, 2905, 344819, 235129, 670689, 797370, 67918, 569918, 466997, 43325, 987744, 259471, 512184, 298491, 295500, 689773, 206726, 385645, 755591, 617506, 268140, 502955, 469787, 907670, 338083, 308543, 388465, 110198, 939508, 759356, 228805, 376349, 278612, 573623, 127829, 949300, 887344, 195747, 35569, 354341, 755423, 23312, 613811, 267606, 321802, 425662, 473731, 44879, 811306, 229321, 178737, 79445, 248627, 648523, 503466, 586709, 473417, 408283, 213259, 412925, 167638, 442063, 305625, 962601, 532037, 433453, 911900, 419380, 145551, 947469, 290072, 900974, 487132, 903882, 684931, 808934, 845895, 158661, 370164, 657200, 387982, 548900, 252997, 152960, 713774, 272814, 739669, 187191, 681096, 952927, 116467, 365085, 911341, 422091, 327685, 443377, 855543, 755937, 379108, 517446, 219757, 669180, 418419, 706888, 89413, 103349, 32173, 451660, 262010, 402337, 625211, 166343, 467588, 878207, 319302, 697714, 667373, 575322, 401256, 864820, 44600, 517722, 229905, 955940, 939812, 73941, 915668, 311706, 346229, 811128, 829151, 565985, 996659, 763921, 789225, 602423, 867270, 821397, 54082, 645631, 740085, 679293, 811973, 207673, 73851, 647626, 905386, 741223, 739300, 306641, 606043, 783899, 340714, 352299, 256191, 280525, 942591, 688210, 108582, 288820, 499337, 937733, 371156, 495995, 218005, 160380, 614770, 85274, 981777, 668851, 247256, 721861, 348143, 575580, 445885, 421994, 223206, 867622 });

        }
        static long countInversions(int[] arr)
        {
            var ret = MergeSortOriginal(ref arr, 0, arr.Length - 1);
            return ret;
        }

        /// <summary>
        /// My second version of Merge Sort. (Complexity goes to O(n²)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int MergeSort1(ref int[] arr, int start, int end)
        {
            if (start >= end)
                return 0;

            int middle = (start + end) / 2;
            int ret = 0;

            ret += MergeSort1(ref arr, start, middle);
            ret += MergeSort1(ref arr, middle + 1, end);

            int s = start;


            //Selection Sort (Complexity goes to O(n²)
            for (int i = start; i <= end; i++)
            {
                for (int j = Math.Max(i, middle) + 1; j <= end; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;

                        ret++;
                    }
                }
            }


            return ret;
        }



        /// <summary>
        /// My own version of merge sort.(Complexity O(log n))
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int MergeSort2(ref int[] arr, int start, int end)
        {
            if (start >= end)
                return 0;

            int middle = (start + end) / 2;

            int ret = 0;

            ret += MergeSort2(ref arr, start, middle);
            ret += MergeSort2(ref arr, middle + 1, end);

            int s = start;
            int m = middle + 1;


            int[] newarr = new int[end - start + 1];

            int i = 0;
            bool lastHalfEnd = false;
            bool firstHalfEnd = false;

            while (i < newarr.Length)
            {
                if ((arr[m] <= arr[s] || firstHalfEnd) && !lastHalfEnd)
                {
                    newarr[i] = arr[m];

                    if (m + 1 <= end)
                        m++;
                    else
                        lastHalfEnd = true;

                    if (!firstHalfEnd)
                        ret++;
                }
                else if ((arr[m] > arr[s] || lastHalfEnd) && !firstHalfEnd)
                {
                    newarr[i] = arr[s];

                    if (s + 1 <= middle)
                        s++;
                    else
                        firstHalfEnd = true;

                    ret += middle + 1 - i;
                }

                i += 1;
            }

            for (int j = 0; j < newarr.Length; j++, start++)
            {
                arr[start] = newarr[j];
            }

            return ret;
        }


        /// <summary>
        /// Original version of merge sort. (Complexity O(log n))
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static long MergeSortOriginal(ref int[] arr, int start, int end)
        {
            if (start >= end)
                return 0;

            int middle = (start + end) / 2;
            long ret = 0;

            ret += MergeSortOriginal(ref arr, start, middle);
            ret += MergeSortOriginal(ref arr, middle + 1, end);

            int s = start;

            //Copy first and second half in the temp arrays
            int[] leftSide = new int[middle + 1 - start];
            int[] rightSide = new int[end - middle];
            int index = 0, i = 0, j = 0;

            for (i = start; i <= middle; i++)
            {
                leftSide[index] = arr[i];
                ++index;
            }

            index = 0;
            for (j = middle + 1; j <= end; j++)
            {
                rightSide[index] = arr[j];
                ++index;
            }

            //Compare the elements of the two subwarrys and merge them
            i = 0;
            j = 0;
            int k = start;

            while (i < leftSide.Length && j < rightSide.Length)
            {
                if (leftSide[i] <= rightSide[j])
                {
                    arr[k] = leftSide[i];
                    i++;
                }
                else
                {
                    arr[k] = rightSide[j];

                    ret += middle - i + 1;
                    j++;
                }
                k++;
            }

            //Copy remaining elements of left side
            while (i < leftSide.Length)
            {
                arr[k] = leftSide[i];
                i++;
                k++;
            }
            //Copy remaining elements of right side.
            while (j < rightSide.Length)
            {
                arr[k] = rightSide[j];
                j++;
                k++;
            }

            return ret;
        }

        static int mergeSort(int[] arr, int array_size)
        {
            int[] temp = new int[array_size];
            return _mergeSort(arr, temp, 0, array_size - 1);

        }
        /* An auxiliary recursive method that sorts the input array and
          returns the number of inversions in the array. */
        static int _mergeSort(int[] arr, int[] temp, int left, int right)
        {
            int mid, inv_count = 0;
            if (right > left)
            {
                /* Divide the array into two parts and call _mergeSortAndCountInv()
                   for each of the parts */
                mid = (right + left) / 2;

                /* Inversion count will be sum of inversions in left-part, right-part
                  and number of inversions in merging */
                inv_count = _mergeSort(arr, temp, left, mid);
                inv_count += _mergeSort(arr, temp, mid + 1, right);

                /*Merge the two parts*/
                inv_count += merge(arr, temp, left, mid + 1, right);
            }
            return inv_count;
        }

        /* This method merges two sorted arrays and returns inversion count in
           the arrays.*/
        static int merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i, j, k;
            int inv_count = 0;

            i = left; /* i is index for left subarray*/
            j = mid;  /* j is index for right subarray*/
            k = left; /* k is index for resultant merged subarray*/
            while ((i <= mid - 1) && (j <= right))
            {
                if (arr[i] <= arr[j])
                {
                    temp[k++] = arr[i++];
                }
                else
                {
                    temp[k++] = arr[j++];

                    /*this is tricky -- see above explanation/diagram for merge()*/
                    inv_count = inv_count + (mid - i);
                }
            }

            /* Copy the remaining elements of left subarray
             (if there are any) to temp*/
            while (i <= mid - 1)
                temp[k++] = arr[i++];

            /* Copy the remaining elements of right subarray
             (if there are any) to temp*/
            while (j <= right)
                temp[k++] = arr[j++];

            /*Copy back the merged elements to original array*/
            for (i = left; i <= right; i++)
                arr[i] = temp[i];

            return inv_count;
        }
    }
}
