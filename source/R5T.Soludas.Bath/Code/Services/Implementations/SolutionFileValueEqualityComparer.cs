using System;

using R5T.Bath;
using R5T.Cambridge.Types;
using R5T.Vandalia;
using R5T.Vandalia.Bath;

using R5T.T0064;


namespace R5T.Soludas.Bath
{
    [ServiceImplementationMarker]
    public class SolutionFileValueEqualityComparer : HumanOutputValueEqualityComparer<SolutionFile>,
        IValueEqualityComparer<SolutionFile>,
        IServiceImplementation
    {
        public SolutionFileValueEqualityComparer(IHumanOutput humanOutput)
            : base(humanOutput)
        {
        }

        public override bool Equals(SolutionFile x, SolutionFile y)
        {
            bool isFormatVersionEqual = x.FormatVersion == y.FormatVersion;

            var isEqual = isFormatVersionEqual;

            if(isEqual)
            {
                this.HumanOutput.WriteLine("Solution files are equal.");
            }
            else
            {
                this.HumanOutput.WriteLine("Solution files NOT equal...");
            }

            return isEqual;
        }
    }
}
