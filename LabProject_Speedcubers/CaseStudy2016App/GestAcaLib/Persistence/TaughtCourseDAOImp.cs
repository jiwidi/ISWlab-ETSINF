namespace GestAcaLib.Persistence
{
    internal class TaughtCourseDAOImp : ITaughtCourseDAO
    {
        private GestAcaDAL gestAcaDAL;

        public TaughtCourseDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}