using CCSharp.Attributes;

namespace CCSharp.AdvancedMath;

/// <summary>
/// A grab bag of common descriptive and inferential statistical functions. Useful for statistical analysis.
/// </summary>
[LuaRequireModule("AdvancedMath.stats", "stats")]
public class Stats
{
    /// <summary>
    /// A simple least-squares linear regression model.
    /// </summary>
    public class LinRegModel
    {
        /// <summary>
        /// The slope of the regression line.
        /// </summary>
        [LuaProperty("slope")] public double Slope { get; set; }

        /// <summary>
        /// The intercept of the regression line.
        /// </summary>
        [LuaProperty("intercept")] public double Intercept { get; set; }
    }

    /// <summary>
    /// The first and third quartiles of a dataset.
    /// </summary>
    public class QuartileResult
    {
        /// <summary>
        /// The first quartile (25th percentile).
        /// </summary>
        [LuaProperty("Q1")] public double? Q1 { get; set; }

        /// <summary>
        /// The third quartile (75th percentile).
        /// </summary>
        [LuaProperty("Q3")] public double? Q3 { get; set; }
    }

    /// <summary>
    /// Results of a Student's t-test.
    /// </summary>
    public class TTestResult
    {
        /// <summary>
        /// The test statistic.
        /// </summary>
        [LuaProperty("t")] public double T { get; set; }

        /// <summary>
        /// The degrees of freedom.
        /// </summary>
        [LuaProperty("df")] public double Df { get; set; }

        /// <summary>
        /// The p-value.
        /// </summary>
        [LuaProperty("p")] public double P { get; set; }
    }

    /// <summary>
    /// Results of a t-test on a linear regression slope.
    /// </summary>
    public class LinRegTTestResult : TTestResult
    {
        /// <summary>
        /// The slope of the fitted regression line.
        /// </summary>
        [LuaProperty("slope")] public double Slope { get; set; }

        /// <summary>
        /// The standard error of the slope estimate.
        /// </summary>
        [LuaProperty("slopeSe")] public double SlopeSe { get; set; }

        /// <summary>
        /// The coefficient of determination R-squared.
        /// </summary>
        [LuaProperty("r2")] public double R2 { get; set; }
    }

    /// <summary>
    /// Computes the sum of numeric values in the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The sum of values (0 if empty).</returns>
    [LuaMethod("stats.sum")]
    public static double Sum(double[] data) => default;

    /// <summary>
    /// Computes the arithmetic mean (average) of the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The mean, or null if the data is empty.</returns>
    [LuaMethod("stats.mean")]
    public static double? Mean(double[] data) => default;

    /// <summary>
    /// Computes the minimum value of the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The minimum value, or null if the data is empty.</returns>
    [LuaMethod("stats.min")]
    public static double? Min(double[] data) => default;

    /// <summary>
    /// Computes the maximum value of the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The maximum value, or null if the data is empty.</returns>
    [LuaMethod("stats.max")]
    public static double? Max(double[] data) => default;

    /// <summary>
    /// Computes population variance by default.
    ///
    /// Set <paramref name="isSample"/> to true for sample variance.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <param name="isSample">True to compute sample variance (divide by n-1).</param>
    /// <returns>The variance, or null if not defined.</returns>
    [LuaMethod("stats.variance")]
    public static double? Variance(double[] data, bool isSample) => default;

    /// <summary>
    /// Computes population variance by default.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The variance, or null if not defined.</returns>
    [LuaMethod("stats.variance")]
    public static double? Variance(double[] data) => default;

    /// <summary>
    /// Computes the standard deviation of the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <param name="isSample">True to compute sample standard deviation.</param>
    /// <returns>The standard deviation, or null if not defined.</returns>
    [LuaMethod("stats.stdev")]
    public static double? Stdev(double[] data, bool isSample) => default;

    /// <summary>
    /// Computes the standard deviation of the dataset using population variance.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The standard deviation, or null if not defined.</returns>
    [LuaMethod("stats.stdev")]
    public static double? Stdev(double[] data) => default;

    /// <summary>
    /// Returns the number of elements in the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The size (n).</returns>
    [LuaMethod("stats.size")]
    public static double Size(double[] data) => default;

    /// <summary>
    /// Computes the range of the dataset.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The range, or null if undefined.</returns>
    [LuaMethod("stats.range")]
    public static double? Range(double[] data) => default;

    /// <summary>
    /// Computes the median (50th percentile).
    ///
    /// If the length is even, returns the average of the two middle values.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The median, or null if empty.</returns>
    [LuaMethod("stats.median")]
    public static double? Median(double[] data) => default;

    /// <summary>
    /// Computes the mode and returns a sorted array of the most frequent value(s).
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>A list of mode values (empty if the data is empty).</returns>
    [LuaMethod("stats.mode")]
    public static double[] Mode(double[] data) => default;

    /// <summary>
    /// Computes the standard error of the mean (commonly called SE) indicating precision.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The standard error, or null if undefined.</returns>
    [LuaMethod("stats.sex")]
    public static double? Sex(double[] data) => default;

    /// <summary>
    /// Computes the asymmetry (skewness) of data around its mean.
    ///
    /// Requires at least 3 observations.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The skewness, or null if undefined.</returns>
    [LuaMethod("stats.skewness")]
    public static double? Skewness(double[] data) => default;

    /// <summary>
    /// Computes the measure of skew (kurtosis) using an excess kurtosis formula variant.
    ///
    /// Requires at least 4 observations and indicates how much peak or tail a distribution would have.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The kurtosis, or null if undefined.</returns>
    [LuaMethod("stats.kurtosis")]
    public static double? Kurtosis(double[] data) => default;

    /// <summary>
    /// Computes the geometric mean.
    ///
    /// Only defined for strictly positive values. Useful for multiplicative rates such as combining percentage growth rates.
    /// </summary>
    /// <param name="data">Sequential array of positive numbers.</param>
    /// <returns>The geometric mean, or null if any value is less than or equal to 0 or the data is empty.</returns>
    [LuaMethod("stats.geometricMean")]
    public static double? GeometricMean(double[] data) => default;

    /// <summary>
    /// Computes the harmonic mean.
    ///
    /// Best used for average rates and ratios, or inverse proportionalities.
    /// </summary>
    /// <param name="data">Sequential array of positive non-zero numbers.</param>
    /// <returns>The harmonic mean, or null if any value is 0 or the data is empty.</returns>
    [LuaMethod("stats.harmonicMean")]
    public static double? HarmonicMean(double[] data) => default;

    /// <summary>
    /// Computes the trimmed mean.
    ///
    /// Removes <paramref name="trim"/> fraction from each tail and averages the rest.
    /// A more reliable measure of central tendency that clamps down outliers by removing a percentage of extremes.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <param name="trim">Fraction to trim from each tail.</param>
    /// <returns>The trimmed mean, or null if undefined.</returns>
    [LuaMethod("stats.trimmedMean")]
    public static double? TrimmedMean(double[] data, double trim) => default;

    /// <summary>
    /// Computes the trimmed mean with a default trim fraction of 0.05.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The trimmed mean, or null if undefined.</returns>
    [LuaMethod("stats.trimmedMean")]
    public static double? TrimmedMean(double[] data) => default;

    /// <summary>
    /// Computes the winsorized mean.
    ///
    /// Clamps extreme values to given quantiles before averaging.
    /// A more reliable measure of central tendency.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <param name="alpha">Fraction to winsorize in each tail.</param>
    /// <returns>The winsorized mean, or null if empty.</returns>
    [LuaMethod("stats.winsorMean")]
    public static double? WinsorMean(double[] data, double alpha) => default;

    /// <summary>
    /// Computes the winsorized mean with a default alpha of 0.05.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The winsorized mean, or null if empty.</returns>
    [LuaMethod("stats.winsorMean")]
    public static double? WinsorMean(double[] data) => default;

    /// <summary>
    /// Computes the weighted mean.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <param name="weights">Weights with the same length as <paramref name="data"/>.</param>
    /// <returns>The weighted mean, or null if lengths mismatch or total weight is zero.</returns>
    [LuaMethod("stats.weightedMean")]
    public static double? WeightedMean(double[] data, double[] weights) => default;

    /// <summary>
    /// Computes the median absolute deviation (MAD).
    ///
    /// A more reliable measure of variability when outliers are present.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The MAD, or null if empty.</returns>
    [LuaMethod("stats.madMedian")]
    public static double? MadMedian(double[] data) => default;

    /// <summary>
    /// Computes the gini coefficient for inequality (0..1).
    ///
    /// Returns 0 for datasets with fewer than 2 elements or zero mean.
    /// Represents how unequally distributed a dataset is.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The gini coefficient in the range 0..1.</returns>
    [LuaMethod("stats.gini")]
    public static double Gini(double[] data) => default;

    /// <summary>
    /// Computes the sample covariance (uses n-1 denominator).
    ///
    /// Represents how much the two datasets vary with each other.
    /// </summary>
    /// <param name="x">First sequential array of numbers.</param>
    /// <param name="y">Second sequential array of numbers.</param>
    /// <returns>The covariance, or null if lengths mismatch or n is less than or equal to 1.</returns>
    [LuaMethod("stats.covariance")]
    public static double? Covariance(double[] x, double[] y) => default;

    /// <summary>
    /// Computes the Pearson correlation coefficient.
    ///
    /// Returns 0 if undefined. Represents the strength and relationship of the covariances.
    /// </summary>
    /// <param name="x">First sequential array of numbers.</param>
    /// <param name="y">Second sequential array of numbers.</param>
    /// <returns>The correlation coefficient in [-1, 1], or 0 if undefined.</returns>
    [LuaMethod("stats.correlation")]
    public static double Correlation(double[] x, double[] y) => default;

    /// <summary>
    /// Computes the percentile using linear interpolation between order statistics.
    ///
    /// Finds the percentile of proportion <paramref name="p"/> for the dataset. <paramref name="p"/> must be in [0, 1].
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <param name="p">Percentile proportion (0..1).</param>
    /// <returns>The percentile value, or null if the data is empty.</returns>
    [LuaMethod("stats.percentile")]
    public static double? Percentile(double[] data, double p) => default;

    /// <summary>
    /// Computes the first and third quartiles.
    ///
    /// Quartiles are found by cutting the dataset in half using the median, and finding the median of those sets.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>A table containing Q1 and Q3.</returns>
    [LuaMethod("stats.quartiles")]
    public static QuartileResult Quartiles(double[] data) => default;

    /// <summary>
    /// Computes the interquartile range Q3 - Q1.
    ///
    /// The distance between the first and third quartiles.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>The IQR, or null if undefined.</returns>
    [LuaMethod("stats.iqr")]
    public static double? Iqr(double[] data) => default;

    /// <summary>
    /// Computes a list of all outliers in the dataset.
    ///
    /// Outliers are values more than 1.5 times the IQR away from either the first or third quartile.
    /// </summary>
    /// <param name="data">Sequential array of numbers.</param>
    /// <returns>A list of outlier values (empty if none).</returns>
    [LuaMethod("stats.outliers")]
    public static double[] Outliers(double[] data) => default;

    /// <summary>
    /// Finds the index of a value in an array-like table using linear search.
    /// </summary>
    /// <param name="tbl">Sequential array to search.</param>
    /// <param name="value">The value to find.</param>
    /// <returns>The index, or null if not found.</returns>
    [LuaMethod("stats.find")]
    public static int? Find(double[] tbl, double value) => default;

    /// <summary>
    /// Generates n quantitative data points between <paramref name="a"/> and <paramref name="b"/>.
    /// </summary>
    /// <param name="n">Number of points. Must be greater than or equal to one.</param>
    /// <param name="a">Lower bound.</param>
    /// <param name="b">Upper bound.</param>
    /// <returns>An array of random values.</returns>
    [LuaMethod("stats.testdata")]
    public static double[] TestData(double n, double a, double b) => default;

    /// <summary>
    /// Generates n quantitative data points between <paramref name="a"/> and 1.
    /// </summary>
    /// <param name="n">Number of points. Must be greater than or equal to one.</param>
    /// <param name="a">Lower bound.</param>
    /// <returns>An array of random values.</returns>
    [LuaMethod("stats.testdata")]
    public static double[] TestData(double n, double a) => default;

    /// <summary>
    /// Generates n quantitative data points between 0 and 1.
    /// </summary>
    /// <param name="n">Number of points. Must be greater than or equal to one.</param>
    /// <returns>An array of random values.</returns>
    [LuaMethod("stats.testdata")]
    public static double[] TestData(double n) => default;

    /// <summary>
    /// Computes a simple least-squares linear regression (y ~ intercept + slope * x).
    ///
    /// Minimizes squared distance to find the line closest to all data points.
    /// </summary>
    /// <param name="x">Independent variable values.</param>
    /// <param name="y">Dependent variable values.</param>
    /// <returns>A model with slope and intercept, or null if undefined.</returns>
    [LuaMethod("stats.linReg")]
    public static LinRegModel LinReg(double[] x, double[] y) => default;

    /// <summary>
    /// Predicts the y value for a given linear regression model at a given x position.
    /// </summary>
    /// <param name="model">A linear model with slope and intercept.</param>
    /// <param name="xval">The value of x.</param>
    /// <returns>The predicted y, or null if the model is missing.</returns>
    [LuaMethod("stats.linRegPred")]
    public static double? LinRegPred(LinRegModel model, double xval) => default;

    /// <summary>
    /// Computes the coefficient of determination R-squared for a linear model.
    ///
    /// Represents how much variation in y can be attributed to x.
    /// </summary>
    /// <param name="x">Independent variable values.</param>
    /// <param name="y">Dependent variable values.</param>
    /// <param name="model">Linear model returned by <see cref="LinReg"/>.</param>
    /// <returns>R-squared (1 if total variance is zero), or null if undefined.</returns>
    [LuaMethod("stats.r2")]
    public static double? R2(double[] x, double[] y, LinRegModel model) => default;

    /// <summary>
    /// Calculates the cumulative distribution function for Student's t distribution.
    ///
    /// Uses a numerical approximation based on the incomplete beta function and continued fraction approximation.
    /// </summary>
    /// <param name="t">The t-statistic value.</param>
    /// <param name="df">Degrees of freedom.</param>
    /// <returns>The probability P(T &lt;= t).</returns>
    [LuaMethod("stats.tCDF")]
    public static double TCdf(double t, double df) => default;

    /// <summary>
    /// Calculates the normal (Gaussian) cumulative distribution function.
    ///
    /// Helper function for tCDF when degrees of freedom is large, using an error function approximation.
    /// </summary>
    /// <param name="x">The value.</param>
    /// <returns>The probability P(X &lt;= x) for the standard normal distribution.</returns>
    [LuaMethod("stats.normalCDF")]
    public static double NormalCdf(double x) => default;

    /// <summary>
    /// Calculates the incomplete beta function I_x(a, b).
    ///
    /// Helper function for tCDF calculation using continued fraction approximation.
    /// </summary>
    /// <param name="x">Upper limit of integration (0 &lt;= x &lt;= 1).</param>
    /// <param name="a">First shape parameter.</param>
    /// <param name="b">Second shape parameter.</param>
    /// <returns>The incomplete beta function value.</returns>
    [LuaMethod("stats.incopmleteBeta")]
    public static double IncopmleteBeta(double x, double a, double b) => default;

    /// <summary>
    /// Calculates the logarithm of the gamma function.
    ///
    /// Helper function for incopmleteBeta using Lanczos approximation coefficients.
    /// </summary>
    /// <param name="x">Input value.</param>
    /// <returns>log(Gamma(x)).</returns>
    [LuaMethod("stats.logGamma")]
    public static double LogGamma(double x) => default;

    /// <summary>
    /// Performs a one-sample t-test.
    ///
    /// Tests whether the sample mean significantly differs from a hypothesized population mean.
    /// Returns a p-value; if p &lt; 0.05, the difference is statistically significant.
    /// </summary>
    /// <param name="data">Sample values.</param>
    /// <param name="mu0">Hypothesized population mean.</param>
    /// <returns>A results table with t, df, and p.</returns>
    [LuaMethod("stats.oneSampleTTest")]
    public static TTestResult OneSampleTTest(double[] data, double mu0) => default;

    /// <summary>
    /// Performs a two-sample t-test.
    ///
    /// Tests whether the means of two independent samples significantly differ.
    /// Returns a p-value; if p &lt; 0.05, the difference is statistically significant.
    /// </summary>
    /// <param name="x">First sample.</param>
    /// <param name="y">Second sample.</param>
    /// <param name="equalVar">Whether to assume equal variances.</param>
    /// <returns>A results table with t, df, and p.</returns>
    [LuaMethod("stats.twoSampleTTest")]
    public static TTestResult TwoSampleTTest(double[] x, double[] y, bool equalVar) => default;

    /// <summary>
    /// Performs a two-sample t-test assuming equal variances.
    /// </summary>
    /// <param name="x">First sample.</param>
    /// <param name="y">Second sample.</param>
    /// <returns>A results table with t, df, and p.</returns>
    [LuaMethod("stats.twoSampleTTest")]
    public static TTestResult TwoSampleTTest(double[] x, double[] y) => default;

    /// <summary>
    /// Performs a paired t-test.
    ///
    /// Tests whether the mean difference between paired observations is significant.
    /// Useful for before/after comparisons on the same subjects.
    /// </summary>
    /// <param name="before">Values before treatment.</param>
    /// <param name="after">Values after treatment.</param>
    /// <returns>A results table with t, df, and p.</returns>
    [LuaMethod("stats.pairTTest")]
    public static TTestResult PairTTest(double[] before, double[] after) => default;

    /// <summary>
    /// Performs a t-test on a linear regression slope.
    ///
    /// Checks a dataset against its linear regression.
    /// </summary>
    /// <param name="x">Independent variable values.</param>
    /// <param name="y">Dependent variable values.</param>
    /// <returns>A results table with t, df, p, slope, slopeSe, and r2.</returns>
    [LuaMethod("stats.linRegTTest")]
    public static LinRegTTestResult LinRegTTest(double[] x, double[] y) => default;
}
