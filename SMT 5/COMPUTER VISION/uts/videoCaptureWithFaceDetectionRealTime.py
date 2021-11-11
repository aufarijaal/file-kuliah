# Mengimpor library yang dibutuhkan
import cv2.cv2 as cv2
import os


# mendefinisikan variabel untuk file cascade wajah dan mata
face_cascade = cv2.CascadeClassifier(os.path.join('data', 'haarcascade_frontalface_default.xml'))
eye = cv2.CascadeClassifier(os.path.join('data','haarcascade_eye.xml'))
# img = cv2.imread('tes0.jpg')
cap = cv2.VideoCapture(0)
# cap = cv2.VideoCapture(0)
font = cv2.FONT_HERSHEY_COMPLEX_SMALL

# perulangan untuk melakukan proses penggambaran teks, kotak pada wajah dan mata dan menampilkan / memutar video sampai selesai
# dan menunggu user klik tombol escape
while 1:
    ret, img = cap.read()
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    # menyimpan hasil pendeteksian wajah
    faces = face_cascade.detectMultiScale(gray, 1.3, 5)

    for (x, y, w, h) in faces:
        # menggambar kotak disekitar wajah yang terdeteksi
        cv2.putText(img, "Wajah", (x, y - 10), font, 0.75, (100, 255, 51), 2, cv2.LINE_AA)
        # draw_text(img, 'wajah', font, x, y-20, 1, 1, (255, 255, 255), (100, 255, 51))
        cv2.rectangle(img, (x, y), (x + w, y + h), (100, 255, 51), 2)
        roi_gray = gray[y:y + h, x:x + w]
        roi_color = img[y:y + h, x:x + w]


        # mendeteksi mata dan menyimpan hasil ke variabel
        mata = eye.detectMultiScale(roi_gray)
        # menggambar kotak disekitar mata
        for (mx, my, mw, mh) in mata:
            cv2.rectangle(roi_color, (mx, my), (mx + mw, my + mh), (255, 255, 0), 2)

    cv2.imshow('deteksi wajah', img)
    k = cv2.waitKey(30) & 0xff
    if k == 27:
        break

resize = cv2.resize(img, (800, 600))
cv2.imshow('Gambar Output', resize)
# cap.release()
cv2.destroyAllWindows()
