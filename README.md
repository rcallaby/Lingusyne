# Lingusyne


An open source A.I. language learning chatbot tutor. This is currently a prototype and not really ready for prime time. It is a work in progress and will obviously need significant improvements before it is ready for production or release.


### Proposed Architecture of the chatbot

```
+------------------------+
|      Frontend UI       | <----> Web (React/Flutter) + Avatar Animations (Unity/Unreal/3D)
+------------------------+
             |
             v
+------------------------+
|   Chatbot Orchestration| <-- NLP Controller (intent, context)
+------------------------+
             |
             v
+------------------------+       +---------------------+
|     Conversation Core  |<----->|  Teaching Strategies |
+------------------------+       +---------------------+
             |
             v
+------------------------+
|    Avatar Personality  | (Strategy + Decorator)
+------------------------+
             |
             v
+------------------------+       +---------------------+
|     Feedback Engine    |<----->| Grammar, Speech, etc |
+------------------------+       +---------------------+
             |
             v
+------------------------+
|     User Progress DB   |
+------------------------+

+-----------------------------+
|       Language Engine       | <-- GPT / LLM API layer
+-----------------------------+


```

