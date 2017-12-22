include irvine32.inc
.data
fpr real4 0.3
fpg real4 0.59
fpb real4 0.11
.code
;-----------------------------------------------------
;Sum PROC Calculates 2 unsigned integers
;Recieves: 2 DWord parametes number 1 and number 2
;Return: the sum of the 2 unsigned numbers into the EAX
;------------------------------------------------------

GreyScale PROC uses esi, myarr:PTR DWORD ,w:DWORD,h:DWORD
;init loop counter(ecx)
mov eax,w
mul h
mov ecx,eax
;init esi with img offset
mov esi,myarr
;init new tmp local var
sub esp,4
 
 
FINIT 
L1:
;st(0)= 0.11*b
movzx eax,byte ptr [esi]
mov [ebp-8],eax
fld fpb
fimul dword ptr [ebp-8]
 
;st(0) =0.59*g
movzx eax,byte ptr [esi+1]
mov [ebp-8],eax
fld fpg
fimul dword ptr [ebp-8]
 
;st(0) =0.3*r
movzx eax,byte ptr [esi+2]
mov [ebp-8],eax
fld fpr
fimul dword ptr [ebp-8]
;st(0)=0.11*b+0.59*g
fadd 
;st(0)=0.11*b+0.59*g+0.3*r
fadd ST(0),ST(1)
;store result &pop in eax
fistp dword ptr [ebp-8]
mov eax,[ebp-8]    
;store gray-scaled value in rgb
mov [esi],al         
mov [esi+1],al
mov [esi+2],al
;make fp stack empty
ffree st(0)
;go to the next pixel
add esi,4
loop L1
;add esp,4
 
 
ret
GreyScale endp


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
		JL L2
		mov byte ptr [esi],255
		jmp next
		L2:
		cmp dx,0
		JG H2
		mov byte ptr [esi],0
		jmp next
		H2:
		mov byte ptr [esi],dl
		next:

		movzx dx,byte ptr [esi+1]
		add dx,bx
		cmp dx,255
		JL L3
		mov byte ptr [esi+1],255
		jmp next2
		L3:
		cmp dx,0
		JG H3
		mov byte ptr [esi+1],0
		jmp next2
		H3:
		mov byte ptr [esi+1],dl
		next2:

		movzx dx,byte ptr [esi+2]
		add dx,bx
		cmp dx,255
		JL L4
		mov byte ptr [esi+2],255
		jmp next3
		L4:
		cmp dx,0
		JG H4
		mov byte ptr [esi+2],0
		jmp next3
		H4:
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