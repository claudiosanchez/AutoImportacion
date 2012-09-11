namespace AutomobileInformation.BL
{
    public interface IAutoMakerRepository
    {
        AutoMaker GetById(string autoMakeId);
    }
}