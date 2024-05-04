## State Digram

```mermaid
stateDiagram-v2
    [*] --> Still
    Still --> [*]

    Still --> Moving: Start Moving 
    Moving --> Still
    Moving --> Crash
    Crash --> [*]
```