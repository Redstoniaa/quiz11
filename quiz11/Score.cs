namespace quiz11
{
    public static class Score
    {
        public static int Correct;
        public static int Total;

        public static void IncrementCorrect()
        {
            Correct++;
            Total++;
        }

        public static void IncrementIncorrect()
        {
            Total++;
        }
    }
}
