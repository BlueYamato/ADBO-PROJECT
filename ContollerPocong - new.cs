u s i n g   U n i t y E n g i n e ;  
 u s i n g   U n i t y E n g i n e . S c e n e M a n a g e m e n t ;  
 p u b l i c   c l a s s   C o n t r o l l e r P o c o n g   :   M o n o B e h a v i o u r  
 {  
 	  
 	 p r i v a t e   V e c t o r 2   j u m p F o r c e   =   n e w   V e c t o r 2 ( 0 ,   3 0 0 ) ;  
  
 	 p r i v a t e   d o u b l e   j u m p C o u n t = 1 ;    
 	 p u b l i c   i n t   a s d = 0 ;  
 	 p u b l i c   R i g i d b o d y 2 D   r b ;  
  
  
 	 v o i d   S t a r t ( ) { 	  
 	 	 r b   =   G e t C o m p o n e n t < R i g i d b o d y 2 D > ( ) ;  
 	 	 P l a y e r P r e f s . S e t I n t ( " s p e e d " ,   5 ) ;  
 	  
 	 }  
 	 v o i d   U p d a t e   ( )  
 	 {  
  
  
 	 	 t r a n s f o r m . T r a n s l a t e ( V e c t o r 3 . r i g h t   *   P l a y e r P r e f s . G e t I n t ( " s p e e d " )   *   T i m e . d e l t a T i m e ) ;  
 	 	 i f   ( I n p u t . G e t K e y U p ( " s p a c e " ) & & j u m p C o u n t > 0 )  
 	 	 {  
  
 	 	 	 J u m p   ( ) ;  
  
 	 	 }  
  
  
 	 }  
 	 v o i d   J u m p ( ) {  
 	 	 j u m p C o u n t   =   0 ;  
  
 	 	 G e t C o m p o n e n t < R i g i d b o d y 2 D >   ( ) . v e l o c i t y   =   V e c t o r 2 . z e r o ;  
 	 	 G e t C o m p o n e n t < R i g i d b o d y 2 D >   ( ) . A d d F o r c e   ( j u m p F o r c e ) ;  
  
 	 }  
  
 	 v o i d   O n C o l l i s i o n E n t e r 2 D ( C o l l i s i o n 2 D   c o l l ) {  
  
 	 	 j u m p C o u n t   =   1 ;  
 	 	 i f   ( c o l l . g a m e O b j e c t . T o S t r i n g   ( ) . E q u a l s   ( " o b s t a c l e " ) )   {  
 	 	 	 c r a s h   =   t r u e ;  
 	 	 }  
 	 }  
  
  
 	 v o i d   D u c k ( ) {  
 	 	 / /   t o   d o  
 	 } }  
  
  
  
  
 