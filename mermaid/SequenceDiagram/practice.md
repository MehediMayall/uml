```mermaid
sequenceDiagram
participant Alice
participant Bob
participant John
actor Devid

Alice->>+Bob: Hi Bob, How are you?
Bob->>-Alice: Fine and you?

Alice->>Bob: Also Fine

Note right of Alice: Alice is thinking about John

Alice->>+John:Hi John, What's up?
John->>-Alice:Going well, what about you?
Alice->>John:Good here
```