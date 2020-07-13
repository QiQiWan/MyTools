using System;


namespace MyTools.MathModel
{
    public class Counter
    {
        public Counter(string id)
        {
            this.count = 0;
            this.id = id;
        }

        private int count;
        private string id;

        public void increment() => count++;
        public int tally() => count;
        public void reset() => count = 0;
        /// <summary>
        /// 返回更大的计数器
        /// </summary>
        /// <param name="other">需要比较的计数器</param>
        /// <returns>较大的计数器</returns>
        public Counter comparedWith(Counter other) => this.tally() > other.tally() ? this : other;
        public override String ToString() => id + ": " + count;
        /// <summary>
        /// 返回较大计数器的静态方法
        /// </summary>
        /// <param name="a">计数器1</param>
        /// <param name="b">计数器2</param>
        /// <returns>较大的计数器</returns>
        static public Counter max(Counter a, Counter b) => a.tally() > b.tally() ? a : b;
    }
}
