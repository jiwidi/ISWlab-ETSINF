namespace GestAcaLib.Persistence
{
    internal class TeacherDAOImp : ITeacherDAO
    {
        private GestAcaDAL gestAcaDAL;

        public TeacherDAOImp(GestAcaDAL gestAcaDAL)
        {
            this.gestAcaDAL = gestAcaDAL;
        }
    }
}