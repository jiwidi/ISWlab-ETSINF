namespace GestAcaLib.Persistence
{
    internal class CourseDAOImp : ICouseDAO
    {
        private GestAcaDAL gestAcaDAL;

        public CourseDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}