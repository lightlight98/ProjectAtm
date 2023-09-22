Chapter 3-2 Unity 게임개발 숙련 개인과제
ATM 시스템 만들기
이름 이형빈
구현한 과제 (ATM 시스템 만들기 )



설정 아이디 "1234"
설정 비밀번호 "1234"

### 요구사항

- 필수요구사항
   - 1. ATM 화면 구성
      - Title
      - 이름
      - 잔액 - 기본 50,000만원
      - 현금 - 기본 100,000만원
      - 입금 버튼 → 2. 입금 기능으로 이동
      - 출금 버튼 → 3. 출금 기능으로 이동
  - 2. 입금 기능
     - 입금 화면 UI 구성
     - 버튼을 누르면 해당 금액 만큼 현금에서 잔액으로 이동
     - 직접 입력을 이용하면 입력한 금액만큼 입금
     - 뒤로가기 버튼을 누르면 1번 화면으로 이동
     - 잔액이 부족하면 팝업 띄우기
     - 잔액 부족
     - 3만원이 있을때 5만원 입금 하려면 잔액 부족
     - 확인 누르면 팝업 닫기
   - 3. 출금 기능
     - 출금 화면 UI 구성
     - 버튼을 누르면 해당 금액 만큼 잔액에서 현금으로 이동     
     - 직접 입력을 이용하면 입력한 금액만큼 출금
     - 뒤로가기 버튼을 누르면 1번 화면으로 이동
     - 잔액이 부족하면 팝업 띄우기
     - 잔액 부족
     - 3만원이 있을때 5만원 출금 하려면 잔액 부족
     - 확인 누르면 팝업 닫기
    
- 선택요구사항
   - 1. 통화 단위 적용 
     - 1000 의 자리 마다 , 표시
     - 1000원이면 1,000
     - 50000원이면 50,000
   - 2. 금액 입력시 숫자만 입력 
     - 인풋박스에 숫자외에 입력 안되게 적용
   - 3. 로그인 기능
     - 실행하면 **필수요구사항 1. ATM** 대신 로그인 화면이 먼저 나타납니다.
     - 아이디와 비밀번호를  입력하면 **필수요구사항 1. ATM** 으로 이동
     - 비밀번호 입력시 마스킹을 통해 *** 으로 표시됩니다.
        
