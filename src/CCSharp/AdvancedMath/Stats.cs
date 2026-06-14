using CCSharp.Attributes;

namespace CCSharp.AdvancedMath;

/// <summary>
/// Common descriptive and inferential statistical functions.
/// </summary>
[LuaRequireModule("AdvancedMath.stats", "stats")]
public class Stats
{
    public class LinRegModel
    {
        [LuaProperty("slope")] public double Slope { get; set; }
        [LuaProperty("intercept")] public double Intercept { get; set; }
    }

    public class QuartileResult
    {
        [LuaProperty("Q1")] public double? Q1 { get; set; }
        [LuaProperty("Q3")] public double? Q3 { get; set; }
    }

    public class TTestResult
    {
        [LuaProperty("t")] public double T { get; set; }
        [LuaProperty("df")] public double Df { get; set; }
        [LuaProperty("p")] public double P { get; set; }
    }

    public class LinRegTTestResult : TTestResult
    {
        [LuaProperty("slope")] public double Slope { get; set; }
        [LuaProperty("slopeSe")] public double SlopeSe { get; set; }
        [LuaProperty("r2")] public double R2 { get; set; }
    }

    [LuaMethod("stats.sum")]
    public static double Sum(double[] data) => default;

    [LuaMethod("stats.mean")]
    public static double? Mean(double[] data) => default;

    [LuaMethod("stats.min")]
    public static double? Min(double[] data) => default;

    [LuaMethod("stats.max")]
    public static double? Max(double[] data) => default;

    [LuaMethod("stats.variance")]
    public static double? Variance(double[] data, bool isSample) => default;

    [LuaMethod("stats.variance")]
    public static double? Variance(double[] data) => default;

    [LuaMethod("stats.stdev")]
    public static double? Stdev(double[] data, bool isSample) => default;

    [LuaMethod("stats.stdev")]
    public static double? Stdev(double[] data) => default;

    [LuaMethod("stats.size")]
    public static double Size(double[] data) => default;

    [LuaMethod("stats.range")]
    public static double? Range(double[] data) => default;

    [LuaMethod("stats.median")]
    public static double? Median(double[] data) => default;

    [LuaMethod("stats.mode")]
    public static double[] Mode(double[] data) => default;

    [LuaMethod("stats.sex")]
    public static double? Sex(double[] data) => default;

    [LuaMethod("stats.skewness")]
    public static double? Skewness(double[] data) => default;

    [LuaMethod("stats.kurtosis")]
    public static double? Kurtosis(double[] data) => default;

    [LuaMethod("stats.geometricMean")]
    public static double? GeometricMean(double[] data) => default;

    [LuaMethod("stats.harmonicMean")]
    public static double? HarmonicMean(double[] data) => default;

    [LuaMethod("stats.trimmedMean")]
    public static double? TrimmedMean(double[] data, double trim) => default;

    [LuaMethod("stats.trimmedMean")]
    public static double? TrimmedMean(double[] data) => default;

    [LuaMethod("stats.winsorMean")]
    public static double? WinsorMean(double[] data, double alpha) => default;

    [LuaMethod("stats.winsorMean")]
    public static double? WinsorMean(double[] data) => default;

    [LuaMethod("stats.weightedMean")]
    public static double? WeightedMean(double[] data, double[] weights) => default;

    [LuaMethod("stats.madMedian")]
    public static double? MadMedian(double[] data) => default;

    [LuaMethod("stats.gini")]
    public static double Gini(double[] data) => default;

    [LuaMethod("stats.covariance")]
    public static double? Covariance(double[] x, double[] y) => default;

    [LuaMethod("stats.correlation")]
    public static double Correlation(double[] x, double[] y) => default;

    [LuaMethod("stats.percentile")]
    public static double? Percentile(double[] data, double p) => default;

    [LuaMethod("stats.quartiles")]
    public static QuartileResult Quartiles(double[] data) => default;

    [LuaMethod("stats.iqr")]
    public static double? Iqr(double[] data) => default;

    [LuaMethod("stats.outliers")]
    public static double[] Outliers(double[] data) => default;

    [LuaMethod("stats.find")]
    public static int? Find(double[] tbl, double value) => default;

    [LuaMethod("stats.testdata")]
    public static double[] TestData(double n, double a, double b) => default;

    [LuaMethod("stats.testdata")]
    public static double[] TestData(double n, double a) => default;

    [LuaMethod("stats.testdata")]
    public static double[] TestData(double n) => default;

    [LuaMethod("stats.linReg")]
    public static LinRegModel LinReg(double[] x, double[] y) => default;

    [LuaMethod("stats.linRegPred")]
    public static double? LinRegPred(LinRegModel model, double xval) => default;

    [LuaMethod("stats.r2")]
    public static double? R2(double[] x, double[] y, LinRegModel model) => default;

    [LuaMethod("stats.tCDF")]
    public static double TCdf(double t, double df) => default;

    [LuaMethod("stats.normalCDF")]
    public static double NormalCdf(double x) => default;

    [LuaMethod("stats.incopmleteBeta")]
    public static double IncopmleteBeta(double x, double a, double b) => default;

    [LuaMethod("stats.logGamma")]
    public static double LogGamma(double x) => default;

    [LuaMethod("stats.oneSampleTTest")]
    public static TTestResult OneSampleTTest(double[] data, double mu0) => default;

    [LuaMethod("stats.twoSampleTTest")]
    public static TTestResult TwoSampleTTest(double[] x, double[] y, bool equalVar) => default;

    [LuaMethod("stats.twoSampleTTest")]
    public static TTestResult TwoSampleTTest(double[] x, double[] y) => default;

    [LuaMethod("stats.pairTTest")]
    public static TTestResult PairTTest(double[] before, double[] after) => default;

    [LuaMethod("stats.linRegTTest")]
    public static LinRegTTestResult LinRegTTest(double[] x, double[] y) => default;
}
