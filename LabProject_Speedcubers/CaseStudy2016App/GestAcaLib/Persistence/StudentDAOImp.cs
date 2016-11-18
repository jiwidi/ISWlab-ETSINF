namespace GestAcaLib.Persistence
{
    internal class StudentDAOImp : IStudentDAO
    {
        private GestAcaDAL gestAcaDAL;

        public StudentDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}