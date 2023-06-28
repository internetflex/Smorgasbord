module Compare

(*
    interface IComparable<Currency> with
        member this.CompareTo other = compare this.Code other.Code

    interface IComparable with
        member this.CompareTo other =
            match other with
            | :? Currency as ccy -> (this :> IComparable<Currency>).CompareTo ccy
            | _ -> invalidArg "other" "Other object must be a Currency"

    interface IEquatable<Currency> with
        member this.Equals other = this.Code = other.Code

    override this.Equals other =
        match other with
        | :? Currency as ccy -> (this :> IEquatable<Currency>).Equals ccy
        | _ -> false

    override this.GetHashCode () = hash this.Code

======= OR

type Concept =

    interface IComparable with
        member this.CompareTo obj =
            match obj with
            | :? Concept as other -> (this :> IComparable<Concept>).CompareTo other
            | _ -> invalidArg "obj" "Other object must be a Concept"

    interface IComparable<Concept> with
        member this.CompareTo other =
            if this.Name.Namespace = other.Name.Namespace
            then compare this.Name.LocalName other.Name.LocalName
            else compare this.Name.NamespaceName other.Name.NamespaceName
*)
