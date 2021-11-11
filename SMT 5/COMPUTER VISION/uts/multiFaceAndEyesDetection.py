# Mengimpor library yang dibutuhkan
import cv2.cv2 as cv2
import os

# mendefinisikan variabel untuk file cascade wajah dan mata
face_cascade = cv2.CascadeClassifier('haarcascade_frontalface_default.xml')
eye_cascade = cv2.CascadeClassifier('haarcascade_eye.xml')

# definisi variabel untuk file foto, convert foto ke abu abu, definisi jenis font, dan variabel untuk
# menampung jumlah wajah yang ada dalam foto
img = cv2.imread(os.path.join('res', 'foto_banyak_orang.jpg'))
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
font = cv2.FONT_HERSHEY_SIMPLEX
jumlah = 0

# menyimpan hasil kalkukasi jumlah wajah pada foto
faces = face_cascade.detectMultiScale(gray, 1.3, 5)

# perulangan untuk meng handle jumlah wajah, penggambaran teks dan kotak pada foto dan memberi keterangan jumlah wajah
for (x, y, w, h) in faces:

    jumlah = jumlah + 1
    cv2.putText(img, "Wajah", (x, y - 10), font, 0.75, (0, 0, 255), 2, cv2.LINE_AA)
    cv2.rectangle(img, (x, y), (x + w, y + h), (255, 0, 0), 2)
    roi_gray = gray[y:y + h, x:x + w]
    roi_color = img[y:y + h, x:x + w]
    eyes = eye_cascade.detectMultiScale(roi_gray)
    for (ex, ey, ew, eh) in eyes:
        cv2.rectangle(roi_color, (ex, ey), (ex + ew, ey + eh), (0, 255, 0), 2)

cv2.putText(img, "Jumlah wajah : " + str(jumlah) + " wajah", (10, 30), font, 1, (0, 0, 0), 2, cv2.LINE_AA)
resize = cv2.resize(img, (10000, 1))
# draw_text(img, "Jumlah wajah : {} wajah".format(str(jumlah)), font, 0, 0, 1, 2, (255, 255, 255))
cv2.imshow('img', img)
cv2.waitKey(0)
cv2.destroyAllWindows()
