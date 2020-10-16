## 卡尔曼增益的推导

某系统的状态空间方程：
$$
\begin{aligned}
x_k & =Ax_{k-1}+Bu_{k-1}+w_{k-1} \\
z_k & =Hx_k+v_k
\end{aligned}
$$

其中$w_k$为过程噪声，$v_k$为测量噪声，两者服从正态分布
$$
\begin{aligned}
p(w)\sim(0,Q) \\
p(v)\sim(0,R)
\end{aligned}
$$

由于过程噪声和测量噪声无法建模，上述方程变为估计值（$\hat{x}$：估计  $x^-$：先验）
$$
\begin{aligned}
\hat{x_k}^- & =A \hat{x}^-_{k-1}+B u_{k-1} \\
z_k & =H x_k
\end{aligned}
$$

利用数据融合的思想
$$
\hat{x}_k=\hat{x}^-_k+G(H^- z_k - \hat{x}_k^-)
$$

令$G=K_k H$，得
$$
\hat{x}_k=\hat{x}^-_k+K_k(z_k - H\hat{x}_k^-)
$$


思路：寻找合适得$K_k$使得$\hat{x}_k \to x_k$估计值趋近于真实值

量化误差：
$$
e_k=x_k - \hat{x}_k
$$

并假设误差也服从正态分布$p(e_k) \sim (0,p)$


















