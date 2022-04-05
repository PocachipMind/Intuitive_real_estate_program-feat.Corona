# Intuitive_real_estate_program-feat.Corona

2021년 1학기 윈도우즈 프로그래밍을 하며 제작한 프로그램.

전체 프로그램 설명 URL : https://youtu.be/2JbaxIU_uhc

<br>

## 개요
전북대 학생들은 타지에서 온 학생들이 많습니다. 

이들은 기숙사를 들어가거나 부동산 앱을 통해 자취집을 구하는데, 이때 코로나 관련정보와 주변 환경에 있는 여러 시설들에 대해 알아 볼수 있는 프로그램이 있으면 좋겠다 생각하였습니다.  프로그램을 제작하게 되었습니다.

추가적으로, 인테리어 기능 의견도 나왔기에 간단히 추가하였습니다.

<br>

## 기술
구현 : Visual Studio

디자인 코드 : XAML

코드 비하인드 : C#

<br>

## 실행 화면

### ※ 자세한 작동기전은 영상을 참고해주세요! ( https://youtu.be/2JbaxIU_uhc )

<br>

프로그램 실행시 기본적으로 나오는 화면입니다.

![메인](https://user-images.githubusercontent.com/101550112/161671994-b0e94f98-4e37-455f-af92-4700bc6e07d5.png)

<br>

![메인 - 복사본](https://user-images.githubusercontent.com/101550112/161672465-403e763d-3fd1-4276-befe-4b48137b7e84.png)


#### ① : 검색 기능. 원하는 카테고리와 코로나 위험도를 설정하여 검색.
#### ② : 코로나 기능. 코로나 확진자 발생지 기준 100m 원 표시.
#### ③ : 거리 측정 기능. 체크한 후 맵 좌클릭을 통해 거리 측정 가능. 우클릭으로 거리 측정 종료.
#### ④ : 카테고리 버튼. 토글 버튼 클릭시 맵상에 토글버튼 해당 카테고리 마크 표시.
#### ⑤ : 맵 이동 버튼. 전북대 근처 자취집이 많은 네 장소 선정, 클릭시 맵 변겅.

<br>

카테고리 버튼에서, 집카테고리를 활성화 시킨후 클릭하게 되면 다음과 같은 창이 뜨게됩니다.

![창](https://user-images.githubusercontent.com/101550112/161676213-1e096d4d-b59a-46d6-974e-eb29127a07ec.png)


이 창에선 탭을 통해 정보 및 인테리어를 해볼수 있습니다.

![창2](https://user-images.githubusercontent.com/101550112/161676563-f2df7259-35c8-48f3-a82d-30bf77d5b024.png)

<br>

## 대략적 프로그램 구조

![apdls](https://user-images.githubusercontent.com/101550112/161677083-d89679dc-8bd8-4d39-add2-0581c497d409.png)
