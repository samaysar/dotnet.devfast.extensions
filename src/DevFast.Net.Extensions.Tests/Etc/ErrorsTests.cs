namespace DevFast.Net.Extensions.Tests.Etc;

[TestFixture]
public class ErrorsTests
{
    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ThrowInvalidOperationExceptionIfFalse_Behaves_Correctly(bool dontThrow)
    {
        if (dontThrow)
        {
            That(dontThrow.ThrowInvalidOperationExceptionIfFalse("will not throw", null), Is.EqualTo(true));
        }
        else
        {
            Exception dummyInner = new("dummy");
            Ioe? ex = Throws<Ioe>(() => dontThrow.ThrowInvalidOperationExceptionIfFalse("will throw", dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo("will throw"));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
        }
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ThrowInvalidOperationExceptionIfTrue_Behaves_Correctly(bool shouldThrow)
    {
        if (shouldThrow)
        {
            Exception dummyInner = new("dummy");
            Ioe? ex = Throws<Ioe>(() => shouldThrow.ThrowInvalidOperationExceptionIfTrue("will throw", dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo("will throw"));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(shouldThrow));
        }
        else
        {
            That(shouldThrow.ThrowInvalidOperationExceptionIfTrue("will not throw", null), Is.EqualTo(shouldThrow));
        }
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ThrowArgumentExceptionOnPredicateFail_Behaves_Correctly(bool dontThrow)
    {
        if (dontThrow)
        {
            That(dontThrow.ThrowArgumentExceptionOnPredicateFail(static x => x, nameof(dontThrow), nameof(ThrowArgumentExceptionOnPredicateFail_Behaves_Correctly), null), Is.EqualTo(true));
        }
        else
        {
            Exception dummyInner = new("dummy");
            Ae? ex = Throws<Ae>(() => dontThrow.ThrowArgumentExceptionOnPredicateFail(static x => x, nameof(dontThrow), nameof(ThrowArgumentExceptionOnPredicateFail_Behaves_Correctly), dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo($"{nameof(dontThrow)} does not satisfy {nameof(ThrowArgumentExceptionOnPredicateFail_Behaves_Correctly)}."));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
        }
    }

    [Test]
    [TestCase(true)]
    [TestCase(false)]
    public void ThrowArgumentExceptionOnPredicateSuccess_Behaves_Correctly(bool shouldThrow)
    {
        if (shouldThrow)
        {
            Exception dummyInner = new("dummy");
            Ae? ex = Throws<Ae>(() => shouldThrow.ThrowArgumentExceptionOnPredicateSuccess(static x => x, nameof(shouldThrow), nameof(ThrowArgumentExceptionOnPredicateSuccess_Behaves_Correctly), dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo($"{nameof(shouldThrow)} satisfied {nameof(ThrowArgumentExceptionOnPredicateSuccess_Behaves_Correctly)}."));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(shouldThrow));
        }
        else
        {
            That(shouldThrow.ThrowArgumentExceptionOnPredicateSuccess(static x => x, nameof(shouldThrow), nameof(ThrowArgumentExceptionOnPredicateSuccess_Behaves_Correctly), null), Is.EqualTo(shouldThrow));
        }
    }

    [Test]
    [TestCase(null)]
    [TestCase(1)]
    public void ThrowArgumentExceptionForNull_Behaves_Correctly(decimal? value)
    {
        if (value.HasValue)
        {
            That(value.ThrowArgumentExceptionForNull(nameof(value)), Is.EqualTo(value.Value));
        }
        else
        {
            Exception dummyInner = new("dummy");
            Ae? ex = Throws<Ae>(() => value.ThrowArgumentExceptionForNull(nameof(value), dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo($"{nameof(value)} was null."));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
        }
    }

    [Test]
    [TestCase(null, true)]
    [TestCase(null, false)]
    [TestCase(1, true)]
    [TestCase(1, false)]
    public void ThrowArgumentExceptionForNullOrOnPredicateFail_Behaves_Correctly(decimal? value, bool shouldThrow)
    {
        if (value.HasValue)
        {
            if (shouldThrow)
            {
                That(value.ThrowArgumentExceptionForNullOrOnPredicateFail(_ => shouldThrow, nameof(shouldThrow), nameof(ThrowArgumentExceptionForNullOrOnPredicateFail_Behaves_Correctly), null), Is.EqualTo(value.Value));
            }
            else
            {
                Exception dummyInner = new("dummy");
                Ae? ex = Throws<Ae>(() => value.ThrowArgumentExceptionForNullOrOnPredicateFail(_ => shouldThrow, nameof(shouldThrow), nameof(ThrowArgumentExceptionForNullOrOnPredicateFail_Behaves_Correctly), dummyInner));
                That(ex, Is.Not.Null);
                That(ex!.Message, Is.EqualTo($"{nameof(shouldThrow)} does not satisfy {nameof(ThrowArgumentExceptionForNullOrOnPredicateFail_Behaves_Correctly)}."));
                That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
            }
        }
        else
        {
            Exception dummyInner = new("dummy");
            Ae? ex = Throws<Ae>(() => value.ThrowArgumentExceptionForNullOrOnPredicateFail(static _ => false, nameof(value), nameof(ThrowArgumentExceptionForNullOrOnPredicateFail_Behaves_Correctly), dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo($"{nameof(value)} was null."));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
        }
    }

    [Test]
    [TestCase(null, true)]
    [TestCase(null, false)]
    [TestCase(1, true)]
    [TestCase(1, false)]
    public void ThrowArgumentExceptionForNullOrOnPredicateSuccess_Behaves_Correctly(decimal? value, bool shouldThrow)
    {
        if (value.HasValue)
        {
            if (shouldThrow)
            {
                Exception dummyInner = new("dummy");
                Ae? ex = Throws<Ae>(() => value.ThrowArgumentExceptionForNullOrOnPredicateSuccess(_ => shouldThrow, nameof(shouldThrow), nameof(ThrowArgumentExceptionForNullOrOnPredicateSuccess_Behaves_Correctly), dummyInner));
                That(ex, Is.Not.Null);
                That(ex!.Message, Is.EqualTo($"{nameof(shouldThrow)} satisfied {nameof(ThrowArgumentExceptionForNullOrOnPredicateSuccess_Behaves_Correctly)}."));
                That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
            }
            else
            {
                That(value.ThrowArgumentExceptionForNullOrOnPredicateSuccess(_ => shouldThrow, nameof(shouldThrow), nameof(ThrowArgumentExceptionForNullOrOnPredicateSuccess_Behaves_Correctly), null), Is.EqualTo(value.Value));
            }
        }
        else
        {
            Exception dummyInner = new("dummy");
            Ae? ex = Throws<Ae>(() => value.ThrowArgumentExceptionForNullOrOnPredicateSuccess(static _ => false, nameof(value), nameof(ThrowArgumentExceptionForNullOrOnPredicateSuccess_Behaves_Correctly), dummyInner));
            That(ex, Is.Not.Null);
            That(ex!.Message, Is.EqualTo($"{nameof(value)} was null."));
            That(ReferenceEquals(ex.InnerException, dummyInner), Is.EqualTo(true));
        }
    }
}