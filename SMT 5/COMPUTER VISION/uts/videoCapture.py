import numpy as np
import cv2.cv2 as cv2

cap = cv2.VideoCapture(0)

while True:
    # caputreq tiap frame
    ret, frame = cap.read()
    # operasi membuat frame dalam bentuk hitam putih(gray scale)
    gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY)
    # menampilkan frame
    cv2.imshow('frame', gray)
    # menetup frame apabila tombol 'q'ditekan
    if cv2.waitKey(1) & 0xFF == ord("q"):
        break
cv2.destroyAllWindows()
cap.release()

