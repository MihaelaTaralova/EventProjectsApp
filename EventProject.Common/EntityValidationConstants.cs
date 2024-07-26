namespace EventProject.Common
{
    public static class EntityValidationConstants
    {
        public static class Customer
        {
            public const int CompanyNameMax = 50;
            public const int CompanyNameMin = 3;

            public const int ContactPersonNameMax = 50;
            public const int ContactPersonNameMin = 7;

            public const int CommentsMax = 400;
            public const int CommentsMin = 5;
        }

        public static class Designer
        {
            public const int FirstNameMax = 30;
            public const int FirstNameMin = 2;

            public const int LastNameMax = 30;
            public const int LastNameMin = 3;
        }

        public static class PrintMaterials
        {
            public const int PrintingHouseNameMax = 60;
            public const int PrintingHouseNameMin = 3;

            public const int ContactNameMax = 60;
            public const int ContactNameMin = 2;

            public const int PersonReleasedMaterialsMax = 30;
            public const int PersonReleasedMaterialsMin = 2;

            public const int DescriptionMax = 300;
            public const int DescriptionMin = 5;
        }

        public static class Project
        {
            public const int ProjectNameMax = 100;
            public const int ProjectNameMin = 3;

            public const int DescriptionMax = 400;
            public const int DescriptionMin = 5;

            public const int CommentsMax = 400;
            public const int CommentsMin = 5;
        }

        public static class Location
        {
            public const int LocationNameMax = 100;
            public const int LocationNameMin = 3;

            public const int ContactNameMax = 60;
            public const int ContactNameMin = 2;

            public const int DescriptionMax = 100;
            public const int DescriptionMin = 5;

        }
        public static class ProjectStatus
        {
            public const int NameMax = 15;
            public const int NameMin = 5;
        }

        public static class ProjectType
        {
            public const int NameMax = 15;
            public const int NameMin = 5;

            public const int DescriptionMax = 300;
            public const int DescriptionMin = 5;
        }

        public static class ApplicationUser
        {
            public const int UserNameMax = 15;
            public const int UserNameMin = 3;

            public const int FirstNameMax = 30;
            public const int FirstNameMin = 2;

            public const int LastNameMax = 30;
            public const int LastNameMin = 2;
        }
    }
}
