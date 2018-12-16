﻿using FaceApp.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceApp.ViewModel
{
    class MainWinCtrl:ViewModelBase
    {
        public MainWinCtrl()
        {
            timeOper = new TimeCtrlOperator();
            statOper = new StatisticsOperator();
            faceOper = new FaceOperator();
            videoOper = new VideoOperator(statOper, faceOper);
        }

        private VideoOperator videoOper = null;
        private VideoOperator VideoOper
        {
            get
            {
                if (videoOper == null)
                    videoOper = new VideoOperator(statOper, faceOper);
                return videoOper;
            }
        }

        private TimeCtrlOperator timeOper;
        public TimeCtrlOperator TimeOper
        {
            get
            {
                return timeOper;
            }
            set
            {
                timeOper = value; NotifyChange();
            }
        }
        private StatisticsOperator statOper;
        public StatisticsOperator StatOper
        {
            get
            {
                return statOper;
            }
            set
            {
                statOper = value; NotifyChange();
            }
        }

        private FaceOperator faceOper;
        public FaceOperator FaceOper
        {
            get
            {
                return faceOper;
            }
            set
            {
                faceOper = value; NotifyChange();
            }
        }
    }
}
