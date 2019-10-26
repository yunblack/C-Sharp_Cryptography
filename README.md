# BASE CRYPTOGRAPHY C#
Online Secret Splitting and Sharing C# Sources

# File Encryption and Online Distributed Sharing System with Cachin’s Online Secret Splitting and Sharing
### Abstract
Basic Online Secret Sharing is a secure secret distribution where the size of the partial information that each participant should keep is the same as the original information size and no unauthorized participant has access to the information. Despite its safety, however, there are not many cases that have been applied and used in real life. Therefore, based on Cachin's theory, we made an application that can be applied to real-life. The application that we are going to make is Basic Online Secret Sharing(BOSS). BOSS is an implementation of Christian Cachin’s On-line Secret Sharing scheme. This implementation provides basic secret sharing including generation of shares and secret reconstruction using the described General Access Structure from the paper. Through this implementation, we are going to find out how the BOSS is effective and useful in our real life.



![그림2](https://user-images.githubusercontent.com/56234205/67622086-88a40200-f851-11e9-8a58-6875c8b86ab9.png)
(Figure 1)
Basic Architecture: The following diagrams illustrate the overall architecture of the system. There are two different subsystems that each has its own architecture. The first is BOSS_Secure which does the work of securing data with a random key, generating shares, and securely distributing shares. This is shown in figure 1.

![그림3](https://user-images.githubusercontent.com/56234205/67622088-893c9880-f851-11e9-9629-47a4c768b692.png)
(Figure 2)
BOSS Access Architecture Detail: The second mechanism is the BOSS_Access subsystem that collects shares, reconstructs a secret and decrypts secure data. This is shown in figure 2. BOSS_Access is slightly more complex than BOSS_Secure. It is operation includes not just collecting the shares but it must determine if the collection matches one of the participant sets from the Tau data. It then applies the inverse algorithm to recover the secret.

