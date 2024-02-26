namespace COMP003A.Assignment6_1
{
    /// <summary>
    /// Interfaces are contracts that inheriting class has to implement. 
    /// Read https://learn.microsoft.com/en-us/dotnet/standard/design-guidelines/abstractions-abstract-types-and-interfaces
    /// </summary>
    internal interface IVehicle
    {
        /// <summary
        /// this method is required to be implemented in the inheriting class
        /// </summary>
        public void GetInfo();

    }
}