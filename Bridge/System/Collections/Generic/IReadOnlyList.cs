using Bridge;

namespace System.Collections.Generic
{
    [External]
    [Reflectable]
    [Convention(Target = ConventionTarget.Member, Member = ConventionMember.Method, Notation = Notation.LowerCamelCase)]
    public interface IReadOnlyList<out T> : IReadOnlyCollection<T>
    {
        T this[int index]
        {
            [Template("System.Array.getItem({this}, {0}, {T})")]
            get;
        }
    }
}