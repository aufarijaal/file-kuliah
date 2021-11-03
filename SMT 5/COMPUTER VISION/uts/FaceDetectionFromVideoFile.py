import cv2.cv2 as cv2
import os

face_cascade = cv2.CascadeClassifier(os.path.join('data', 'haarcascade_frontalface_default.xml'))
# img = cv2.imread('tes0.jpg')
cap = cv2.VideoCapture('vidio.mp4')
# cap = cv2.VideoCapture(0)
font = cv2.FONT_HERSHEY_COMPLEX_SMALL


def draw_text(image, text,
              fontFace = cv2.FONT_HERSHEY_PLAIN,
              posX=0,
              posY=0,
              font_scale=1,
              font_thickness=2,
              text_color=(0, 255, 0),
              text_color_bg=(0, 0, 0)
              ):
    text_size, _ = cv2.getTextSize(text, font, font_scale, font_thickness)
    text_w, text_h = text_size
    cv2.rectangle(img, (posX, posY), (posX + text_w, posY + text_h), text_color_bg, -1)
    cv2.putText(img, text, (posX, posY + text_h + font_scale - 1), font, font_scale, text_color, font_thickness)

    return text_size


while 1:
    ret, img = cap.read()
    gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
    faces = face_cascade.detectMultiScale(gray, 1.3, 5)

    for (x, y, w, h) in faces:
        # cv2.putText(img, "Wajah", (x, y - 10), font, 0.75, (100, 255, 51), 2, cv2.LINE_AA)
        draw_text(img, 'wajah', font, x, y-20, 1, 1, (255, 255, 255), (100, 255, 51))
        cv2.rectangle(img, (x, y), (x + w, y + h), (100, 255, 51), 2)
        roi_gray = gray[y:y + h, x:x + w]
        roi_color = img[y:y + h, x:x + w]

    cv2.imshow('deteksi wajah', img)
    k = cv2.waitKey(30) & 0xff
    if k == 27:
        break

resize = cv2.resize(img, (800, 600))
cv2.imshow('Gambar Output', resize)
# cap.release()
cv2.destroyAllWindows()
