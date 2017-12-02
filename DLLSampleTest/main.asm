include irvine32.inc
.data
;no static data
.code
;-----------------------------------------------------
;Sum PROC Calculates 2 unsigned integers
;Recieves: 2 DWord parametes number 1 and number 2
;Return: the sum of the 2 unsigned numbers into the EAX
;------------------------------------------------------
Brightness PROC arr:PTR DWORD, W:DWORD, H:DWORD,Val:DWORD
	push ebx
	push eax
	push ecx
	push esi
	push edx

	mov esi,arr
	mov ebx,val
	mov eax,W
	mul H
	mov ecx,eax
	L1:
		movzx dx,byte ptr [esi]
		add dx,bx
		cmp dx,255
		JB L2
		mov byte ptr [esi],255
		jmp next
		L2:
		mov byte ptr [esi],dl
		next:

		movzx dx,byte ptr [esi+1]
		add dx,bx
		cmp dx,255
		JB L3
		mov byte ptr [esi+1],255
		jmp next2
		L3:
		mov byte ptr [esi+1],dl
		next2:

		movzx dx,byte ptr [esi+2]
		add dx,bx
		cmp dx,255
		JB L4
		mov byte ptr [esi+2],255
		jmp next3
		L4:
		mov byte ptr [esi+2],dl
		next3:

		add esi,4
	LOOP L1

	pop edx
	pop esi
	pop ecx
	pop eax
	pop ebx
	ret
Brightness ENDP
;-----------------------------------------------------
;Sum PROC Calculates 2 unsigned integers
;Recieves: 2 DWord parametes number 1 and number 2
;Return: the sum of the 2 unsigned numbers into the EAX
;------------------------------------------------------
Sum PROC int1:DWORD, int2:DWORD
	mov eax, int1
	add eax, int2
	ret
Sum ENDP

;-----------------------------------------------------
;SumArr PROC Calculates Sum of an array
;Recieves: Offset and the size of an array
;Return: the sum of the array into the EAX
;------------------------------------------------------
SumArr PROC arr:PTR DWORD, sz:DWORD
	push esi
	push ecx

	mov esi, arr
	mov ecx, sz
	mov eax, 0
	sum_loop:
		add eax, DWORD PTR [esi]
		add esi, 4
	loop sum_loop
	
	pop ecx
	pop esi
	Ret
SumArr ENDP

;----------------------------------------------------------------
;Sum PROC convert an array of bytes from lower case to upper case
;Recieves: offset of byte array and it's size
;---------------------------------------------------------------
ToUpper PROC str1:PTR BYTE, sz:DWORD
	push esi
	push ecx
	
	mov esi, str1
	mov ecx, sz
	l1:
		;input validations (Limitation the char to be between a and z)
		cmp byte ptr [esi], 'a'
		jb skip
		cmp byte ptr [esi], 'z'
		ja skip

		and byte ptr [esi], 11011111b
		skip:
		inc esi
	loop l1
	
	pop ecx
	pop esi
	ret
ToUpper ENDP


; DllMain is required for any DLL
DllMain PROC hInstance:DWORD, fdwReason:DWORD, lpReserved:DWORD
mov eax, 1 ; Return true to caller.
ret
DllMain ENDP
END DllMain