﻿//******************************************************************************************************************************************************************************************//
// Copyright (c) 2011 George Mamaladze                                                                                                                                                      //
//                                                                                                                                                                                          //
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"),                                       //
// to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software,   //
// and to permit persons to whom the Software is furnished to do so, subject to the following conditions:                                                                                   //
//                                                                                                                                                                                          //
// The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.                                                           //
//                                                                                                                                                                                          //
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,                                      //
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,                            //
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.                               //
//                                                                                                                                                                                          //
//******************************************************************************************************************************************************************************************//

using System.Linq;
using Neos.IdentityServer.MultiFactor.QrEncoding.Positioning;

namespace Neos.IdentityServer.MultiFactor.QrEncoding.Masking.Scoring
{
    internal static class MatrixScoreCalculator
    {
        internal static BitMatrix GetLowestPenaltyMatrix(this TriStateMatrix matrix, ErrorCorrectionLevel errorlevel)
        {
            PatternFactory patternFactory = new PatternFactory();
            int score = int.MaxValue;
            int tempScore;
            TriStateMatrix result = new TriStateMatrix(matrix.Width);
            TriStateMatrix triMatrix;
            foreach(Pattern pattern in patternFactory.AllPatterns())
            {
            	triMatrix = matrix.Apply(pattern, errorlevel);
            	tempScore = triMatrix.PenaltyScore();
            	if(tempScore < score)
            	{
            		score = tempScore;
            		result = triMatrix;
            	}
            }
            
            return result;
        }


        internal static int PenaltyScore(this BitMatrix matrix)
        {
            PenaltyFactory penaltyFactory = new PenaltyFactory();
            return
            	penaltyFactory
            	.AllRules()
            	.Sum(penalty => penalty.PenaltyCalculate(matrix));
        }
    }
}