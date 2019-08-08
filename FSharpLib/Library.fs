namespace FSharpLib

open UnityEngine

type HelloWorldScript() =
    inherit MonoBehaviour()
    member this.Start() =
        Debug.Log("F#: Hello World!!!")
        Debug.Log(TestScript.Say("Hi!"))