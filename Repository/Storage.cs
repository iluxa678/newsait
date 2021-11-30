

namespace newsait.Repository
{
    public static class Storage
    {
        public static AppealStorage AppealStorage { get; } = new AppealStorage();
        public static BreedStorage BreedStorage { get; } = new BreedStorage();
        public static ClientStorage ClientStorage { get; } = new ClientStorage();
        public static ConclusionStorage ConclusionStorage { get; } = new ConclusionStorage();
        public static DiagStorage DiagStorage { get; } = new DiagStorage();
        public static DoctStorage DoctStorage { get; } = new DoctStorage();
        public static GenderStorage GenderStorage { get; } = new GenderStorage();
        public static IllStorage IllStorage { get; } = new IllStorage();
        public static MetodStorage MetodStorage { get; } = new MetodStorage();
        public static PetStorage PetStorage { get; } = new PetStorage();
        public static PositionStorage PositionStorage { get; } = new PositionStorage();
        public static RecomendStorage RecomendStorage { get; } = new RecomendStorage();
        public static ServiceStorage ServiceStorage { get; } = new ServiceStorage();
        public static SimptomIllStorage SimptomIllStorage { get; } = new SimptomIllStorage();
        public static SimptomStorage SimptomStorage { get; } = new SimptomStorage();
        public static SortPetStorage SortPetStorage { get; } = new SortPetStorage();
        public static StatusStorage StatusStorage { get; } = new StatusStorage();
        public static OperatorStorage OperatorStorage { get; } = new OperatorStorage();
    }
}