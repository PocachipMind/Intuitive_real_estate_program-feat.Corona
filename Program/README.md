# Intuitive_real_estate_program-feat.Corona

프로그램 실행을 위한 폴더입니다. 

Step에 따라 프로그램 실행을 해주십시오.

<br>

※) Code 폴더는 프로그램 실행이 아닌, 코드만을 보고자 하는 인원을 위한 코드 보관소입니다.

<br>

## Step 1. Visual studio 보유.

이 프로젝트는 웹을 구현하여 작동하는데, 웹 서버를 구축할 때 무료 버전을 사용하여, 지금은 현재 서버가 닫혀있습니다.

아무 설정없이 프로그램을 실행한다면, 프로그램 맵 부분에 보라색 화면 tiiny 사이트가 뜨며 실행이 되지 않을 것입니다.

기본적으로 프로그램에 사용한 HTML 서버가 정상 작동 중 이라면 exe 파일을 통해 바로 실행할 수 있겠으나 제작 시 서버를 임시로 사용했기에 갱신이 필요합니다.

이에, 갱신을 위해 Visual studio를 활용합니다.

<br>

## Step 2. zip 파일 다운로드 이후 실행

서버 갱신을 위해 visual studio project 파일을 다운받겠습니다.

CoronaTrace - HTML.zip 파일을 다운 받은 후 압축을 해제하고 프로젝트를 실행해 주세요.

<br>

## Step 3. 카카오 지도 API 사용을 위한 앱 키 발급받기

먼저 서버 갱신하기 전, 카카오 지도 API를 사용하기 위한 키를 발급 받습니다.

#### > 1. 카카오 개발자 사이트에 접속합니다

카카오 개발자 사이트 : https://developers.kakao.com

#### > 2. '내 에플리케이션'을 클릭하고 '로그인' 합니다.

![카카오개발자사이트](https://user-images.githubusercontent.com/101550112/175454261-a50ed0db-d6a5-422d-b4d9-f37645013d81.png)

#### > 3.  '애플리케이션 추가하기'를 클릭합니다.

![애플리케이션](https://user-images.githubusercontent.com/101550112/175454492-81e0123d-c24e-4fa1-a69f-34438b4e151f.png)

#### > 4. '앱이름' , '사업자명'을 입력하여 애플리케이션을 추가합니다.

![애플추가하기](https://user-images.githubusercontent.com/101550112/175474198-872d68fe-7380-484f-b38b-aaae6c6c3da0.png)

#### > 5. 사용하는 플랫폼을 등록하고 '사이트 도메인'을 저장합니다
API를 사용하기 위해 서버를 하나 개설합니다. 그리고 그 서버에서 카카오 API를 사용할 수 있도록 사이트 도메인을 추가해줍니다.

저는 서버를 개설하는데 다음과 같은 사이트에 도움을 받았습니다.


도움을 받은 사이트 : https://tiiny.host/manage

![앱설정1](https://user-images.githubusercontent.com/101550112/175476912-05a6ba3b-f20c-4b32-9df7-a12ea72d6d81.png)

![앱설정2](https://user-images.githubusercontent.com/101550112/175476915-cdf900cb-cc90-4f69-a781-886cd8f57e45.png)

![앱설정3](https://user-images.githubusercontent.com/101550112/175476895-e7de5a5e-d01a-4ee8-a254-711626afcbef.png)

<br>

## Step 4. 코드 내에서 Web Browser 사이트 갱신

1. 먼저 다음과 같은 파일 내 HTML을 이용하여 서버를 개설해 줍니다.

![설명](https://user-images.githubusercontent.com/101550112/161687589-cf300305-f89c-4368-ad37-3b2bccde2f39.png)

2. MapWindowVM.cs 코드에서 개설한 서버의 주소를 입력합니다.

![설명2](https://user-images.githubusercontent.com/101550112/161687817-2450328f-8888-4935-bb03-b9e1fdd15634.png)

## Step 5. 실행

Visual Studio 내에서 컨트롤 + F5를 통해 실행합니다.

![프로그램11](https://user-images.githubusercontent.com/101550112/161691644-2a3f8a1d-b746-4964-9dde-3909414e56f6.png)
