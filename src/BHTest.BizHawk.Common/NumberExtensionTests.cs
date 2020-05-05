using BizHawk.Common.NumberExtensions;

using Xunit;

namespace BizHawk.Common.Test
{
	public class NumberExtensionTests
	{
		public static readonly TheoryData<int, string> TestInt32ToHexString_Data = new TheoryData<int, string>
		{
			{ 0, "00000000" },
			{ 1, "00000001" },
			{ 32194756, "01EB40C4" },
			{ int.MaxValue, "7FFFFFFF" },
			{ int.MinValue, "80000000" },
			{ -1, "FFFFFFFF" }
		};

		[MemberData(nameof(TestInt32ToHexString_Data))]
		[Theory]
		public void TestInt32ToHexString(int i, string expected)
		{
			const int width = 8;
			Assert.Equal(expected, i.ToHexString(width));
		}
	}
}
