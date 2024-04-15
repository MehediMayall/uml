```mermaid
sequenceDiagram
    participant Alice
    participant John
    participant Carl
    actor Donald

    Note right of Alice: Some greetings first
    Alice->>+John: Hello John, how are you?
    John->>-Alice: Great!
    Alice-)John: See you later!

    John-xCarl: Hi,Carl
    Alice-xCarl: We are too many

    Note over Alice,John: A note that overlap participants

    Carl->>Donald:Hi!

    loop Every Minute
        Alice-->John:Great! Go ahead
    end
```
