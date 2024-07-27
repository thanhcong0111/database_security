# Database Security
Some labs in Database Security subject in HCMUS will be exploited. They are about decentralization, access control, hash functions, symmetric keys, asymmetric keys, and so forth.

### Lab 2: The decentralization  MySQL

Decentralize roles and privileges to a special account. If you don't have permission, the screen will alert to you:

![Screenshot 2024-07-24 213800](https://github.com/user-attachments/assets/d6f7cf94-3eac-4f15-9bb1-44db1ffacfcb)

It includes decentralization of reading, updating, inserting, etc. in the whole table or specific columns. At the same time, store procedures are required to perform some specific tasks.

### Lab 3: The access control method with encrypted data in MySQL databases

- With personal lab: control the user accessing if they exist or not

The password column was hashed by *MD5*, and the salary column was encrypted by *AES256*. Then write an application to control user access.

![Screenshot 2024-07-24 211503](https://github.com/user-attachments/assets/71782a44-f26a-454d-911c-de52a075e0ad)

- With a group lab, there will be more columns than in the former lab. It's also got access control, like in a in a personal lab, where the password column were hashed by *SHA1* and the salary and score columns was encrypted by *RSA*. In addition, it allows a teacher to modify the information they hold.

![Screenshot 2024-07-24 212747](https://github.com/user-attachments/assets/be68f245-0f86-4c60-b5e2-894e2924250c)

The information will be encrypted and cannot see if you don't have privileges. 

![Screenshot 2024-07-24 213141](https://github.com/user-attachments/assets/4cbb7c90-b851-4078-bddb-c7fd5322f9fe)

However, if you have permission to access SQL Profiler, the information can be leaked.

![Screenshot 2024-07-24 213448](https://github.com/user-attachments/assets/1e86f3a9-f44a-4a08-bda2-fd2f34169940)

### Lab 4: The access control method with encrypted data before inserting it into the database in MySQL

It is almost identical to Lab 3, but with data that has been encrypted before being inserted into the database layer, it also means that encryption will be done between the backend layer and the database.

- With personal lab: control the user accessing if they exist or not

![image](https://github.com/user-attachments/assets/5f6538dc-d467-4cbd-8079-0e465e8a5283)

- With a group lab, there will be more columns than in the former lab. It's also got access control, like in a in a personal lab, where the password column were hashed by *SHA1* and the salary and score columns was encrypted by *RSA*. Therefore, it need to build a *RSA* class to encrypt data before inserting to database. In addition, it allows a teacher to modify the information they hold.

![image](https://github.com/user-attachments/assets/eeeb37a1-384f-40b7-8ab4-13334a86ba91)

The information will be encrypted and cannot see if you don't have privileges. Although you have permission to access SQL Profiler, the information cannot be leaked.

![image](https://github.com/user-attachments/assets/d9734d8b-7d93-43ef-b7e9-eaa3bf2506c1)

Thanks to [Dao Thi Ngoc Giau](https://github.com/Giau39) and Kien Dinh My Hanh - members of my teamwork assisted me in finishing this assignments.

For more information, you can also read the report (Vietnamese version) to understand this session.
