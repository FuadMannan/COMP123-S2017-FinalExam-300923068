using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Fuad Mannan
 * Date: August 17, 2017
 * Description: This is the ScoreBoard class
 * Version: 0.1 - Created the Face enum
 */

namespace COMP123_S2017_FinalExam_3009230681
{
    public class ScoreBoard
    {
        //Private Instance Variables
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;

        //Public Properties

        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {                
                this._score = value;
                this.ScoreTextBox.Text = _score.ToString();
                this.FinalScoreTextBox.Text = _score.ToString();
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = value;
                this.TimeTextBox.Text = _time.ToString();
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //METHODS
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }

        public void UpdateTime()
        {
            int currentTime = Convert.ToInt16(TimeTextBox.Text) - 1;
            string currentTimeStr = currentTime.ToString();
            this.TimeTextBox.Text = currentTimeStr;
        }
    }
}
