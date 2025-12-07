# eAirFlow  
Seminar project for the *Software Development II* class

## Instructions for Running the Application

After cloning the repository, perform the following steps:

### Backend (Docker)

1. Extract: **.env.zip**  
2. Place the `.env` file in the root of the project.

⚠️ If your operating system removes the leading dot, rename the file manually to `.env`.

3. Open a terminal inside the project directory: \eAirFlow
4. Run the following command: docker compose up --build


This will start the backend API, SQL database, and RabbitMQ service.

---

## Desktop Application

1. Extract: **fit-build-2025-12-06-desktop.zip**  
2. Open the extracted folder.  
3. Run: eairflow_desktop.exe


4. Log in using user, employee and admin credentials (listed below).  


---

## Mobile Application

Before installing the mobile application, ensure that an older version is not already installed on the Android emulator.  
If it exists — uninstall it first.

1. Extract: **fit-build-2025-12-06-mobile.zip**  
2. Drag **app-release.apk** (inside `flutter-apk`) into the Android emulator.  
3. Once installed, open the app and sign in using organizer or user credentials.

---

## Notes

- Users can browse flights, reserve seats, make payments, and receive real-time notifications.
- Users cannot perform check-in for reservation ticket unless the flight status is set to **“boarding”**.
- Admin dashboard displays reports based on flight statuses (completed, cancelled, delayed) and total revenue from all bookings.
- Mobile application is intended for employees and regular users.
- The recommender system suggests flights based on a user's reservation history and travel patterns.
- Desktop navigation uses sidebar navigation; detail screens include a back button.

---

## Login Credentials

### Desktop Application  
**User**  
Email: **user@example.com**  
Password: **test**

**Employee**  
Email: **employee@example.com**  
Password: **test**

**Administrator**  
Email: **admin@example.com**  
Password: **test**

---

### Mobile Application

**User**  
Email: **user@example.com**  
Password: **test**

**Employee**  
Email: **employee@example.com**  
Password: **test**

---

### Paypal Credentials
Email: **eairflowpay@personal.example.com**  
Password: **eairflow**

---

## RabbitMQ

RabbitMQ was used to send emails to users after successful registration and flight booking.








