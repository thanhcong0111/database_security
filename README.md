# Database Security
Some labs in Database Security subject in HCMUS will be exploited. They are about decentralization, access control, hash functions, symmetric keys, asymmetric keys, and so forth.

### Lab 2: The decentralization in MySQL

Decentralize roles and privileges to a special account. If you don't have permission, the screen will alert to you:

![Screenshot 2024-07-24 213800](https://github.com/user-attachments/assets/d6f7cf94-3eac-4f15-9bb1-44db1ffacfcb)

### Lab 3: The access control method with encrypted datas in MySQL databases

- With personal lab:

The password column was hashed by *MD5*, and the salary column was encrypted by *AES256*. Then write an application to control user access.

![Screenshot 2024-07-24 211503](https://github.com/user-attachments/assets/71782a44-f26a-454d-911c-de52a075e0ad)

- With a group lab, there will be more columns than in the former lab. It's also got access control, like in a in a personal lab, where the password column was hashed by *SHA1* and the salary column was encrypted by *RSA*. In addition, it allows a teacher to modify the information they hold.

![Screenshot 2024-07-24 212747](https://github.com/user-attachments/assets/be68f245-0f86-4c60-b5e2-894e2924250c)

The information will be encrypted and cannot see if you don't have privileges. 

![Screenshot 2024-07-24 213141](https://github.com/user-attachments/assets/4cbb7c90-b851-4078-bddb-c7fd5322f9fe)

However, if you have permission to access SQL Profiler, the information can be leaked.

![Screenshot 2024-07-24 213448](https://github.com/user-attachments/assets/1e86f3a9-f44a-4a08-bda2-fd2f34169940)

### Lab 4: The access control method with encrypted datas before insert to database in MySQL

