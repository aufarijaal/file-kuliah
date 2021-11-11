# Mengimpor library yang dibutuhkan
import cv2.cv2 as cv2
import os

# mendefinisikan variabel untuk file cascade wajah
face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
# img = cv2.imread('tes0.jpg')

# fungsi untuk membaca video dari fungsi VideoCapture dan memasukkannya ke dalam variabel
cap = cv2.VideoCapture('vidio.mp4')
# cap = cv2.VideoCapture(0)

# mendefinisikan jenis font yang akan digunakan untuk meletakkan teks pada video mengenai
# keterangan wajah
font = cv2.FONT_HERSHEY_COMPLEX_SMALL



# perulangan untuk melakukan proses penggambaran teks, kotak dan menampilkan / memutar video sampai selesai
# dan menunggu user klik tombol escape
while 1:
    # definisi variabel
    ret, img = cap.read()
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray, 1.3, 5)

    # perulangan for yang digunakan untuk menggambar teks dan kotak pada video yang terdapat wajah
    for (x, y, w, h) in faces:
        cv2.putText(img, "Wajah", (x, y - 10), font, 0.75, (100, 255, 51), 2, cv2.LINE_AA)
        cv2.rectangle(img, (x, y), (x + w, y + h), (100, 255, 51), 2)
        roi_gray = gray[y:y + h, x:x + w]
        roi_color = img[y:y + h, x:x + w]

    cv2.imshow('deteksi wajah', img)
    k = cv2.waitKey(30) & 0xff
    if k == 27:
        break

# resize foto ke 800 x 600
resize = cv2.resize(img, (800, 600))
# menampilkan gambar yang telah diresize
cv2.imshow('Gambar Output', resize)
# cap.release()

# menutup aplikasi
cv2.destroyAllWindows()
